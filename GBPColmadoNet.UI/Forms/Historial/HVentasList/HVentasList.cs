using GBPColmadoNet.UI.Services;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GBPColmadoNet.UI.Forms.Historial.HVentasForm
{
    public partial class HVentasList : Form
    {
        private readonly VentasService _ventasService;
        private readonly ConfiguracionService _configuracionService;

        public HVentasList(VentasService ventasService, ConfiguracionService configuracionService)
        {
            InitializeComponent();
            _ventasService = ventasService;
            _configuracionService = configuracionService;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await BuscarHistorial();
        }

        private async System.Threading.Tasks.Task BuscarHistorial()
        {
            string clienteBusqueda = txtCliente.Text.Trim();
            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);

            Expression<Func<Data.Models.Venta, bool>> criterio;

            if (string.IsNullOrEmpty(clienteBusqueda))
            {
                criterio = v => v.Fecha >= fechaDesde && v.Fecha <= fechaHasta;
            }
            else
            {
                criterio = v => v.Fecha >= fechaDesde && v.Fecha <= fechaHasta &&
                                (v.Cliente != null && v.Cliente.Nombre.Contains(clienteBusqueda));
            }

            var ventas = await _ventasService.GetListWithDetails(criterio);

            var ventasHistorial = ventas.Select(v => new
            {
                NoVenta = v.VentaId,
                Fecha = v.Fecha?.ToString("dd/MM/yyyy hh:mm tt") ?? "",
                Cliente = v.Cliente?.Nombre ?? "Consumidor Final",
                TotalNeto = v.TotalNeto.ToString("N2"),
                ITBIS = v.TotalItbis.ToString("N2"),
                TotalGeneral = (v.TotalNeto + v.TotalItbis).ToString("N2")
            }).OrderByDescending(v => v.NoVenta).ToList();

            dgvVentas.DataSource = ventasHistorial;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Text = string.Empty;
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            dgvVentas.DataSource = null;
            txtCliente.Focus();
        }

        private async void HVentasList_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            await BuscarHistorial();
        }

        private void lblHasta_Click(object sender, EventArgs e)
        {

        }

        private async void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una venta para reimprimir.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ventaId = Convert.ToInt32(dgvVentas.SelectedRows[0].Cells["NoVenta"].Value);
            await ImprimirFactura(ventaId);
        }
        private async Task ImprimirFactura(int ventaId)
        {
            try
            {
                QuestPDF.Settings.License = LicenseType.Community;

                var config = await _configuracionService.ObtenerConfiguracionAsync();
                var ventas = await _ventasService.GetListWithDetails(v => v.VentaId == ventaId);
                var venta = ventas.FirstOrDefault();

                if (venta == null) return;

                var document = Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.ContinuousSize(58, Unit.Millimetre);
                        page.Margin(4, Unit.Millimetre);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(10).FontFamily(Fonts.Arial));

                        page.Content().Column(col =>
                        {
                            // Encabezado
                            col.Item().AlignCenter().Text(config?.NombreComercial ?? "Mi Negocio").Bold().FontSize(12);
                            if (!string.IsNullOrEmpty(config?.Direccion))
                                col.Item().AlignCenter().Text(config.Direccion);
                            if (!string.IsNullOrEmpty(config?.Telefono))
                                col.Item().AlignCenter().Text($"Tel: {config.Telefono}");
                            if (!string.IsNullOrEmpty(config?.Rnc))
                                col.Item().AlignCenter().Text($"RNC: {config.Rnc}");

                            col.Item().PaddingVertical(2).LineHorizontal(1).LineColor(Colors.Grey.Medium);

                            // Info Factura
                            col.Item().Text($"Factura #: {venta.VentaId}");
                            col.Item().Text($"Fecha: {venta.Fecha:yyyy-MM-dd HH:mm:ss}");
                            col.Item().Text($"Cliente: {(venta.Cliente != null ? venta.Cliente.Nombre : "Consumidor Final")}");

                            col.Item().PaddingVertical(2).LineHorizontal(1).LineColor(Colors.Grey.Medium);

                            // Productos Header
                            col.Item().Table(table =>
                            {
                                table.ColumnsDefinition(columns =>
                                {
                                    columns.RelativeColumn(3); // Producto
                                    columns.RelativeColumn(1); // Cant
                                    columns.RelativeColumn(2); // Total
                                });

                                table.Header(header =>
                                {
                                    header.Cell().Text("Producto").Bold();
                                    header.Cell().Text("Cant.").Bold();
                                    header.Cell().AlignRight().Text("Total").Bold();
                                });

                                foreach (var item in venta.VentasDetalles)
                                {
                                    table.Cell().Text(item.Producto?.Nombre ?? "Desc");
                                    table.Cell().Text(item.Cantidad.ToString("N2"));
                                    table.Cell().AlignRight().Text((item.Cantidad * item.PrecioUnitario).ToString("N2"));
                                }
                            });

                            col.Item().PaddingVertical(2).LineHorizontal(1).LineColor(Colors.Grey.Medium);

                            // Totales
                            decimal subtotal = venta.TotalNeto;
                            col.Item().Text($"Subtotal: RD$ {subtotal:N2}");

                            decimal totalPagado = venta.TotalNeto + venta.TotalItbis;
                            col.Item().Text($"Total: RD$ {totalPagado:N2}").Bold();
                            col.Item().Text($"ITBIS: RD$ {venta.TotalItbis:N2}");

                            col.Item().PaddingVertical(2).LineHorizontal(1).LineColor(Colors.Grey.Medium);

                            col.Item().AlignCenter().Text(config?.MensajeTicket ?? "¡Gracias por su compra!");
                        });
                    });
                });

                string tempPath = Path.Combine(Path.GetTempPath(), $"Factura_{ventaId}_{DateTime.Now:yyyyMMddHHmmss}.pdf");
                document.GeneratePdf(tempPath);

                Process.Start(new ProcessStartInfo
                {
                    FileName = tempPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar factura: {ex.Message}");
            }
        }
    }
}
