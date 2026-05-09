using GBPColmadoNet.UI.Services;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace GBPColmadoNet.UI.Forms.Historial.HVentasForm
{
    public partial class HVentasList : Form
    {
        private readonly VentasService _ventasService;

        public HVentasList(VentasService ventasService)
        {
            InitializeComponent();
            _ventasService = ventasService;
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
    }
}
