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
        private readonly ConfiguracionService _configuracionService;

        private ConfiguracionesNegocio? _configuracion;
        private bool _precioVentaCalculadoAutomaticamente = true;
        private decimal _margenConfigurado = 20;
        private decimal _itbisConfigurado = 18;

        public CrearProductoForm(ProductoService productoService,
            CategoriaService categoriaService,
            ProveedorService proveedorService,
            ConfiguracionService configuracionService)
        {
            InitializeComponent();
            _productoService = productoService;
            _categoriaService = categoriaService;
            _proveedorService = proveedorService;
            _configuracionService = configuracionService;

            numericUpDownPrecioCompra.ValueChanged += NumericUpDownPrecioCompra_ValueChanged;
            numericUpDownPrecioVenta.Leave += NumericUpDownPrecioVenta_Leave;
            numericUpDownPrecioVenta.Enter += NumericUpDownPrecioVenta_Enter;

            RbtnItbis18.CheckedChanged += (s, e) => { if (RbtnItbis18.Checked) CalcularValores(); };
            RbtnItbis10.CheckedChanged += (s, e) => { if (RbtnItbis10.Checked) CalcularValores(); };
            RbtnItebis28.CheckedChanged += (s, e) => { if (RbtnItebis28.Checked) CalcularValores(); };
            EbtnNoItebis.CheckedChanged += (s, e) => { if (EbtnNoItebis.Checked) CalcularValores(); };

            this.Load += async (s, e) =>
            {
                await CargarConfiguracion();
                await CargarCombos();
            };
        }

        private async Task CargarConfiguracion()
        {
            try
            {
                _configuracion = await _configuracionService.ObtenerConfiguracionAsync();

                if (_configuracion != null)
                {
                    _margenConfigurado = _configuracion.MargenGananciaDefecto > 0
                        ? _configuracion.MargenGananciaDefecto
                        : 20;

                    _itbisConfigurado = _configuracion.ItbisDefecto > 0
                        ? _configuracion.ItbisDefecto
                        : 18;
                }

                switch ((int)_itbisConfigurado)
                {
                    case 18:
                        RbtnItbis18.Checked = true;
                        break;
                    case 10:
                        RbtnItbis10.Checked = true;
                        break;
                    case 28:
                        RbtnItebis28.Checked = true;
                        break;
                    default:
                        EbtnNoItebis.Checked = true;
                        break;
                }

                lbInfoItbis.Text = $"ITBIS ({_itbisConfigurado}%): RD$ 0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar configuración: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NumericUpDownPrecioCompra_ValueChanged(object sender, EventArgs e)
        {
            if (_precioVentaCalculadoAutomaticamente)
            {
                CalcularPrecioVentaSugerido();
            }
            CalcularValores();
        }

        private void NumericUpDownPrecioVenta_Enter(object sender, EventArgs e)
        {
            _precioVentaCalculadoAutomaticamente = false;
        }

        private void NumericUpDownPrecioVenta_Leave(object sender, EventArgs e)
        {
            CalcularValores();
        }

        private void CalcularPrecioVentaSugerido()
        {
            decimal precioCompra = numericUpDownPrecioCompra.Value;

            if (precioCompra > 0)
            {
                decimal precioVentaSugerido = precioCompra * (1 + (_margenConfigurado / 100));
                numericUpDownPrecioVenta.Value = Math.Round(precioVentaSugerido, 2);
            }
            else
            {
                numericUpDownPrecioVenta.Value = 0;
            }
        }

        private void CalcularValores()
        {
            decimal precioCompra = numericUpDownPrecioCompra.Value;
            decimal precioVenta = numericUpDownPrecioVenta.Value;
            decimal tasa = ObtenerTasaSeleccionada();

            decimal itbisCalculado = precioVenta * (tasa / 100);
            decimal totalCliente = precioVenta + itbisCalculado;
            decimal ganancia = precioVenta - precioCompra;
            decimal margenReal = precioCompra > 0 ? ((precioVenta - precioCompra) / precioCompra) * 100 : 0;

            lbInfoItbis.Text = $"ITBIS ({tasa}%): RD$ {itbisCalculado:N2}";
            lbVentaFinalItbis.Text = $"Total Cliente: RD$ {totalCliente:N2}";
            lbGanancia.Text = $"Ganancia: RD$ {ganancia:N2} ({margenReal:N1}%)";

            bool margenBajo = precioCompra > 0 && margenReal < _margenConfigurado;
            lbGanancia.ForeColor = margenBajo ? Color.Red : Color.Green;

            if (margenBajo && !_precioVentaCalculadoAutomaticamente)
            {
                lbGanancia.Text += " - MARGEN BAJO!";
            }
        }

        private decimal ObtenerTasaSeleccionada()
        {
            if (RbtnItbis18.Checked) return 18;
            if (RbtnItbis10.Checked) return 10;
            if (RbtnItebis28.Checked) return 28;
            return 0;
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

                decimal tasa = ObtenerTasaSeleccionada();

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
            _precioVentaCalculadoAutomaticamente = true;
            lbInfoItbis.Text = $"ITBIS ({_itbisConfigurado}%): RD$ 0.00";
            lbVentaFinalItbis.Text = "Total Cliente: RD$ 0.00";
            lbGanancia.Text = "Ganancia: RD$ 0.00 (0%)";
            lbGanancia.ForeColor = Color.Black;
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