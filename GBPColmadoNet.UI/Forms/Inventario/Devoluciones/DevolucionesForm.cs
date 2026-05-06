using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet.UI.Forms.Inventario.Devoluciones
{
    public partial class DevolucionesForm : Form
    {
        private readonly DevolucionService _devolucionService;
        private readonly VentasService _ventasService;
        private List<Venta> _ventas;
        private Venta? _ventaSeleccionada;
        private VentasDetalle? _productoSeleccionado;

        public DevolucionesForm()
        {
            InitializeComponent();
            _devolucionService = Program.ServiceProvider.GetRequiredService<DevolucionService>();
            _ventasService = Program.ServiceProvider.GetRequiredService<VentasService>();
            _ventas = new List<Venta>();
        }

        private async void DevolucionesForm_Load(object sender, EventArgs e)
        {
            await CargarVentas();
        }

        private async Task CargarVentas()
        {
            try
            {
                _ventas = await _devolucionService.GetVentasDisponiblesAsync();

                cmbVenta.DisplayMember = "DisplayVenta";
                cmbVenta.ValueMember = "VentaId";
                cmbVenta.DataSource = _ventas;

                cmbVenta.AutoCompleteMode = AutoCompleteMode.None;

                if (_ventas.Count == 0)
                {
                    MessageBox.Show("No hay ventas disponibles para procesar devoluciones.", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ventas: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVenta.SelectedValue is int ventaId)
            {
                _ventaSeleccionada = _ventas.FirstOrDefault(v => v.VentaId == ventaId);
                MostrarProductosVenta();
            }
        }

        private void MostrarProductosVenta()
        {
            if (_ventaSeleccionada?.VentasDetalles == null)
            {
                dgvProductosVenta.DataSource = null;
                return;
            }

            var productosParaMostrar = _ventaSeleccionada.VentasDetalles.Select(vd => new
            {
                vd.ProductoId,
                vd.Producto?.Nombre,
                vd.Cantidad,
                vd.PrecioUnitario,
                Total = vd.Cantidad * vd.PrecioUnitario
            }).ToList();

            dgvProductosVenta.DataSource = productosParaMostrar;
        }

        private bool ValidateForm()
        {
            errorProviderDevolucion.Clear();
            bool valid = true;

            if (_ventaSeleccionada == null)
            {
                errorProviderDevolucion.SetError(cmbVenta, "Debe seleccionar una venta.");
                valid = false;
            }

            if (dgvProductosVenta.SelectedRows.Count == 0)
            {
                errorProviderDevolucion.SetError(dgvProductosVenta, "Debe seleccionar un producto.");
                valid = false;
            }

            if (numericCantidad.Value <= 0)
            {
                errorProviderDevolucion.SetError(numericCantidad, "La cantidad debe ser mayor a 0.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                errorProviderDevolucion.SetError(txtMotivo, "El motivo de la devolución es obligatorio.");
                valid = false;
            }

            return valid;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (dgvProductosVenta.SelectedRows.Count == 0) return;

            var filaSeleccionada = dgvProductosVenta.SelectedRows[0];
            int productoId = Convert.ToInt32(filaSeleccionada.Cells["ProductoId"].Value);
            string nombreProducto = filaSeleccionada.Cells["Nombre"].Value?.ToString() ?? "";
            decimal precioUnitario = Convert.ToDecimal(filaSeleccionada.Cells["PrecioUnitario"].Value);
            int cantidadVendida = Convert.ToInt32(filaSeleccionada.Cells["Cantidad"].Value);

            if (numericCantidad.Value > cantidadVendida)
            {
                MessageBox.Show($"La cantidad a devolver no puede exceder la cantidad comprada ({cantidadVendida}).", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnGuardar.Enabled = false;

                decimal montoReembolsado = precioUnitario * numericCantidad.Value;

                var devolucion = new Devolucion
                {
                    VentaId = _ventaSeleccionada!.VentaId,
                    ProductoNombre = nombreProducto,
                    Cantidad = (int)numericCantidad.Value,
                    MontoReembolsado = montoReembolsado,
                    Motivo = txtMotivo.Text.Trim(),
                    Estado = "Pendiente",
                    FechaRegistro = DateTime.Now,
                    UsuarioId = SessionManager.CurrentUser?.UsuarioId
                };

                bool exito = await _devolucionService.Guardar(devolucion);

                if (exito)
                {
                    MessageBox.Show("Devolución registrada correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar la devolución.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                var realMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Error de Base de Datos: {realMsg}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}