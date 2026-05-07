using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;

namespace GBPColmadoNet.UI.Forms.Inventario.ESForm
{
    public partial class ModificarInventarioForm : Form
    {
        private readonly ProductoService _productoService;
        private readonly CategoriaService _categoriaService;
        private readonly ProveedorService _proveedorService;
        private Producto _producto;
        private ErrorProvider errorProviderES;

        public ModificarInventarioForm(ProductoService productoService,
            CategoriaService categoriaService,
            ProveedorService proveedorService,
            Producto producto)
        {
            InitializeComponent();
            _productoService = productoService;
            _categoriaService = categoriaService;
            _proveedorService = proveedorService;
            _producto = producto;
            errorProviderES = new ErrorProvider();

            numericUpDownPrecioCompra.ValueChanged += (s, e) => CalcularValores();
            numericUpDownPrecioVenta.ValueChanged += (s, e) => CalcularValores();
            RbtnItbis18.CheckedChanged += (s, e) => { if (RbtnItbis18.Checked) CalcularValores(); };
            RbtnItbis10.CheckedChanged += (s, e) => { if (RbtnItbis10.Checked) CalcularValores(); };
            RbtnItebis28.CheckedChanged += (s, e) => { if (RbtnItebis28.Checked) CalcularValores(); };

            btnGuardar.Click += btnGuardar_Click;
            btnLimpiarFormulario.Click += btnLimpiarFormulario_Click;
            txCodigoBarras.KeyDown += txCodigoBarras_KeyDown;

            this.Load += async (s, e) => await CargarCombosYDatos();
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

                var resultados = await _productoService.GetList(p =>
                    p.CodigoBarras == criterio ||
                    p.Nombre.Contains(criterio));

                var prodEncontrado = resultados.FirstOrDefault();

                if (prodEncontrado == null && int.TryParse(criterio, out int idBusqueda))
                {
                    prodEncontrado = await _productoService.Buscar(idBusqueda);
                }

                if (prodEncontrado != null)
                {
                    _producto = prodEncontrado;
                    CargarDatosProducto();
                    txNombreProducto.Focus();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado. Verifique el código.", "Búsqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarCombosYDatos()
        {
            try
            {
                var categorias = await _categoriaService.GetList(c => true);
                var proveedores = await _proveedorService.GetList(p => true);

                CboxCategoria.DataSource = categorias;
                CboxCategoria.DisplayMember = "Nombre";
                CboxCategoria.ValueMember = "CategoriaId";

                CboxProveedor.DataSource = proveedores;
                CboxProveedor.DisplayMember = "Nombre";
                CboxProveedor.ValueMember = "ProveedorId";

                if (_producto != null)
                {
                    CargarDatosProducto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar catálogos: {ex.Message}");
            }
        }

        private void CargarDatosProducto()
        {
            if (_producto == null) return;

            txCodigoBarras.Text = _producto.CodigoBarras;
            txNombreProducto.Text = _producto.Nombre;
            numericUpDownPrecioCompra.Value = _producto.PrecioCompra;
            numericUpDownPrecioVenta.Value = _producto.PrecioVenta;
            numericUpDownStock.Value = _producto.Stock ?? 0;

            if (_producto.TasaItbis == 18) RbtnItbis18.Checked = true;
            else if (_producto.TasaItbis == 10) RbtnItbis10.Checked = true;
            else if (_producto.TasaItbis == 28) RbtnItebis28.Checked = true;
            else EbtnNoItebis.Checked = true;

            if (_producto.CategoriaId.HasValue)
                CboxCategoria.SelectedValue = _producto.CategoriaId.Value;

            if (_producto.ProveedorId.HasValue)
                CboxProveedor.SelectedValue = _producto.ProveedorId.Value;

            chkActivo.Checked = _producto.Activo ?? true;

            CalcularValores();
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
                    await _categoriaService.Guardar(nuevaCat);
                    categoriaId = nuevaCat.CategoriaId;
                }

                int? proveedorId = (int?)CboxProveedor.SelectedValue;
                if (proveedorId == null && !string.IsNullOrWhiteSpace(CboxProveedor.Text))
                {
                    var nuevoProv = new Proveedore { Nombre = CboxProveedor.Text.Trim() };
                    await _proveedorService.Guardar(nuevoProv);
                    proveedorId = nuevoProv.ProveedorId;
                }

                decimal tasa = RbtnItbis18.Checked ? 18 : (RbtnItbis10.Checked ? 10 : (RbtnItebis28.Checked ? 28 : 0));

                _producto.CodigoBarras = txCodigoBarras.Text.Trim();
                _producto.Nombre = txNombreProducto.Text.Trim();
                _producto.PrecioCompra = numericUpDownPrecioCompra.Value;
                _producto.PrecioVenta = numericUpDownPrecioVenta.Value;
                _producto.Stock = numericUpDownStock.Value;
                _producto.TasaItbis = tasa;
                _producto.CategoriaId = categoriaId;
                _producto.ProveedorId = proveedorId;
                _producto.Activo = chkActivo.Checked;
                _producto.FechaModificacion = DateTime.Now;

                await _productoService.Guardar(_producto);

                MessageBox.Show("Producto actualizado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                var realMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                if (realMsg.Contains("UNIQUE KEY") || realMsg.Contains("Cannot insert duplicate key"))
                {
                    MessageBox.Show("El Código de Barras ingresado ya pertenece a otro producto en el sistema. \n\nPor favor, asigne un código de barras único.", "Código Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Error de Base de Datos: {realMsg}", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                btnGuardar.Enabled = true;
            }
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
                errorProviderES.SetError(txNombreProducto, "El nombre del producto es obligatorio.");
                valid = false;
            }

            if (numericUpDownPrecioCompra.Value < 0)
            {
                errorProviderES.SetError(numericUpDownPrecioCompra, "El precio de compra es obligatorio u mayor a 0.");
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
            txCodigoBarras.Clear();
            txNombreProducto.Clear();
            numericUpDownPrecioCompra.Value = 0;
            numericUpDownPrecioVenta.Value = 0;
            numericUpDownStock.Value = 0;
            EbtnNoItebis.Checked = false;
            RbtnItbis10.Checked = false;
            RbtnItbis18.Checked = false;
            RbtnItebis28.Checked = false;
            CboxCategoria.SelectedIndex = -1;
            CboxProveedor.SelectedIndex = -1;
            CboxCategoria.Text = string.Empty;
            CboxProveedor.Text = string.Empty;
            txCodigoBarras.Focus();
        }
    }
}
