using GBPColmadoNet.Data.Context;
using GBPColmadoNet.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace GBPColmadoNet.UI.Forms.Inventario.ESForm
{
    public partial class EForm : Form
    {
        private readonly ProductoService _service;
        private Data.Models.Producto? _productoActual;

        public EForm(ProductoService service)
        {
            InitializeComponent();
            _service = service;
            BloquearCampos(false);
        }

        private async void txCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(txCodigoBarras.Text))
                {
                    await BuscarProducto(txCodigoBarras.Text.Trim());
                    e.SuppressKeyPress = true;
                }
            }
        }

        private async Task BuscarProducto(string criterio)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(criterio)) return;

                var resultados = await _service.GetList(p =>
                    p.CodigoBarras == criterio ||
                    p.Nombre.Contains(criterio));

                _productoActual = resultados.FirstOrDefault();

                if (_productoActual == null && int.TryParse(criterio, out int idBusqueda))
                {
                    _productoActual = await _service.Buscar(idBusqueda);
                }

                if (_productoActual != null)
                {
                    CargarDatosEnPantalla();
                    BloquearCampos(true);

                    numericUpDownStockIngresado.Focus();
                    numericUpDownStockIngresado.Select(0, numericUpDownStockIngresado.Text.Length);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado. Verifique el código.", "Búsqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosEnPantalla()
        {
            if (_productoActual == null) return;

            txNombreProducto.Text = _productoActual.Nombre;
            numericUpDownPrecioCompra.Value = _productoActual.PrecioCompra;
            numericUpDownPrecioVenta.Value = _productoActual.PrecioVenta;

            CboxCategoria.Text = _productoActual.Categoria?.Nombre ?? "Sin Categoría";
            CboxProveedor.Text = _productoActual.Proveedor?.Nombre ?? "Sin Proveedor";

            if (_productoActual.TasaItbis == 18) RbtnItbis18.Checked = true;
            else if (_productoActual.TasaItbis == 10) RbtnItbis10.Checked = true;
            else if (_productoActual.TasaItbis == 28) RbtnItebis28.Checked = true;
            else EbtnNoItebis.Checked = true;

            numericUpDownStock.Value = _productoActual.Stock ?? 0;

            numericUpDownStockIngresado.Value = 0;
        }

        private void BloquearCampos(bool productoEncontrado)
        {
            txNombreProducto.ReadOnly = true;
            numericUpDownPrecioCompra.Enabled = false;
            numericUpDownPrecioVenta.Enabled = false;
            CboxCategoria.Enabled = false;
            CboxProveedor.Enabled = false;
            numericUpDownStock.Enabled = false;

            numericUpDownStockIngresado.Enabled = productoEncontrado;
            btnGuardar.Enabled = productoEncontrado;
        }

        public void LimpiarFormulario()
        {
            _productoActual = null;
            txCodigoBarras.Clear();
            txNombreProducto.Clear();
            numericUpDownPrecioCompra.Value = 0;
            numericUpDownPrecioVenta.Value = 0;
            numericUpDownStock.Value = 0;
            numericUpDownStockIngresado.Value = 0;
            EbtnNoItebis.Checked = false;
            RbtnItbis10.Checked = false;
            RbtnItbis18.Checked = false;
            RbtnItebis28.Checked = false;
            txCodigoBarras.Focus();
            BloquearCampos(false);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_productoActual == null || numericUpDownStockIngresado.Value <= 0)
            {
                MessageBox.Show("Debe cargar un producto e ingresar una cantidad válida mayor a 0.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnGuardar.Enabled = false;

                decimal stockActual = _productoActual.Stock ?? 0;
                _productoActual.Stock = stockActual + numericUpDownStockIngresado.Value;
                _productoActual.FechaModificacion = DateTime.Now;

                bool exito = await _service.Modificar(_productoActual);

                if (exito)
                {
                    MessageBox.Show($"Inventario actualizado con éxito. Nuevo Stock: {_productoActual.Stock}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el producto.", "Error");
                }

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Error al guardar la entrada: {msg}", "Error de Base de Datos");
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}