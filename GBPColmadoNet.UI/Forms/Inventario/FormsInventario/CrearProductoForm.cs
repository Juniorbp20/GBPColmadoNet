using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Forms.Inventario.ESForm;
using GBPColmadoNet.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet.UI.Forms
{
    public partial class CrearProductoForm : Form
    {
        private readonly ProductoService _productoService;
        private readonly CategoriaService _categoriaService;
        private readonly ProveedorService _proveedorService;

        public CrearProductoForm(ProductoService productoService,
            CategoriaService categoriaService,
            ProveedorService proveedorService)
        {
            InitializeComponent();
            _productoService = productoService;
            _categoriaService = categoriaService;
            _proveedorService = proveedorService;

            numericUpDownPrecioCompra.ValueChanged += (s, e) => CalcularValores();
            numericUpDownPrecioVenta.ValueChanged += (s, e) => CalcularValores();
            RbtnItbis18.CheckedChanged += (s, e) => { if (RbtnItbis18.Checked) CalcularValores(); };
            RbtnItbis10.CheckedChanged += (s, e) => { if (RbtnItbis10.Checked) CalcularValores(); };
            RbtnItebis28.CheckedChanged += (s, e) => { if (RbtnItebis28.Checked) CalcularValores(); };

            CalcularValores();
            _ = CargarCombos();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                btnGuardar.Enabled = false;

                int? categoriaId = (int?)CboxCategoria.SelectedValue;
                if (categoriaId == null && !string.IsNullOrWhiteSpace(CboxCategoria.Text))
                {
                    var nuevaCat = new Categoria { Nombre = CboxCategoria.Text.Trim() };
                    var resultado = await _categoriaService.Guardar(nuevaCat);
                    categoriaId = nuevaCat.CategoriaId;
                }

                int? proveedorId = (int?)CboxProveedor.SelectedValue;
                if (proveedorId == null && !string.IsNullOrWhiteSpace(CboxProveedor.Text))
                {
                    var nuevoProv = new Proveedore { Nombre = CboxProveedor.Text.Trim() };
                    var resultado = await _proveedorService.Guardar(nuevoProv);
                    proveedorId = nuevoProv.ProveedorId;
                }

                decimal tasa = RbtnItbis18.Checked ? 18 : (RbtnItbis10.Checked ? 10 : (RbtnItebis28.Checked ? 28 : 0));

                var producto = new Producto()
                {
                    CodigoBarras = txCodigoBarras.Text.Trim(),
                    Nombre = txNombreProducto.Text.Trim(),
                    PrecioCompra = numericUpDownPrecioCompra.Value,
                    PrecioVenta = numericUpDownPrecioVenta.Value,
                    Stock = numericUpDownStock.Value,
                    TasaItbis = tasa,
                    Activo = true,
                    CategoriaId = categoriaId,
                    ProveedorId = proveedorId,
                    FechaRegistro = DateTime.Now,
                    FechaModificacion = DateTime.Now
                };

                await _productoService.Guardar(producto);

                MessageBox.Show("Producto creado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

            }
            catch (Exception ex)
            {
                var realMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Error de Base de Datos: {realMsg}", "Error al guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
        }

        private bool ValidateForm()
        {
            errorProviderES.Clear();
            bool valid = true;

            if (string.IsNullOrWhiteSpace(txCodigoBarras.Text))
            {
                errorProviderES.SetError(txCodigoBarras, "El codigo de barras es obligatorio.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txNombreProducto.Text))
            {
                errorProviderES.SetError(txNombreProducto, "El nombre del producto es obligatirio.");
                valid = false;
            }

            if (numericUpDownPrecioCompra.Value < 0)
            {
                errorProviderES.SetError(numericUpDownPrecioCompra, "El precio de compra es obligatirio u mayor a 0.");
                valid = false;
            }

            if (numericUpDownPrecioVenta.Value < 0)
            {
                errorProviderES.SetError(numericUpDownPrecioVenta, "El  precio de venta es obligatorio y mayor a 0.");
                valid = false;
            }

            if (numericUpDownPrecioVenta.Value < numericUpDownPrecioCompra.Value)
            {
                errorProviderES.SetError(numericUpDownPrecioVenta, $"Alerta! El precio de venta no debe ser menor al de compra");
                valid = false;
            }

            if (CboxCategoria.SelectedValue == null && string.IsNullOrWhiteSpace(CboxCategoria.Text))
            {
                errorProviderES.SetError(CboxCategoria, "Debe seleccionar una categoría.");
                valid = false;
            }

            if (CboxProveedor.SelectedValue == null && string.IsNullOrWhiteSpace(CboxProveedor.Text))
            {
                errorProviderES.SetError(CboxProveedor, "Debe seleccionar un proveedor.");
                valid = false;
            }

            return valid;
        }

        private void CalcularValores()
        {
            decimal costo = numericUpDownPrecioCompra.Value;
            decimal precioBase = numericUpDownPrecioVenta.Value;
            decimal tasa = 0;

            if (RbtnItbis18.Checked) tasa = 18;
            else if (RbtnItbis10.Checked) tasa = 10;
            else if (RbtnItebis28.Checked) tasa = 28;

            decimal itbisCalculado = precioBase * (tasa / 100);
            decimal precioFinal = precioBase + itbisCalculado;
            decimal ganancia = precioBase - costo;

            lbInfoItbis.Text = $"ITBIS ({tasa}%): RD$ {itbisCalculado:N2}";
            lbVentaFinalItbis.Text = $"Total Cliente: RD$ {precioFinal:N2}";
            lbGanancia.Text = $"Ganancia: RD$ {ganancia:N2}";

            lbGanancia.ForeColor = ganancia <= 0 ? Color.Red : Color.DarkGreen;
        }

        private void btnLimpiarFormulario_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        public void LimpiarFormulario()
        {
            txCodigoBarras.Clear();
            txNombreProducto.Clear();
            numericUpDownPrecioCompra.Value = 0;
            numericUpDownPrecioVenta.Value = 0;
            numericUpDownStock.Value = 0;
            EbtnNoItebis.Checked = false;
            RbtnItbis10.Checked = false;
            RbtnItbis18.Checked = false;
            RbtnItebis28.Checked = false;
            CboxCategoria.Text = string.Empty;
            CboxProveedor.Text = string.Empty;
            txCodigoBarras.Focus();
        }

        private async Task CargarCombos()
        {
            try
            {
                var categorias = await _categoriaService.GetList(c => true);
                var proveedores = await _proveedorService.GetList(p => true);

                CboxCategoria.DataSource = categorias;
                CboxCategoria.DisplayMember = "Nombre";
                CboxCategoria.ValueMember = "CategoriaId";
                CboxCategoria.SelectedIndex = -1;
                CboxCategoria.Text = "";

                CboxProveedor.DataSource = proveedores;
                CboxProveedor.DisplayMember = "Nombre";
                CboxProveedor.ValueMember = "ProveedorId";
                CboxProveedor.SelectedIndex = -1;
                CboxProveedor.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar catálogos: {ex.Message}");
            }
        }
    }
}
