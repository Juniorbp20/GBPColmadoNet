using GBPColmadoNet.UI.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;
using System.Threading.Tasks;
using ListarModel = GBPColmadoNet.Data.Models.Producto;

namespace GBPColmadoNet.UI.Forms.Inventario.ESForm
{

    public partial class ListarProductosList : Form
    {
        private readonly ProductoService _service;
        // para la barra de busqueda
        private CancellationTokenSource _cancellationTokenSource;
        private bool _isSearching = false;
        private bool _viendoInactivos = false;

        public ListarProductosList(ProductoService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void lbTituloList_Click(object sender, EventArgs e)
        {

        }

        private async void ESList_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                bool estadoBuscado = !_viendoInactivos;
                var productosParaMostrar = await _service.GetList(d => (d.Activo ?? true) == estadoBuscado);
                productoDataGridView.DataSource = null;
                productoDataGridView.DataSource = productosParaMostrar;

                ConfigurarDiseñoGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error de Carga",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDiseñoGrid()
        {
            productoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            productoDataGridView.Dock = DockStyle.Fill;

            if (productoDataGridView.Columns["Precio"] != null)
                productoDataGridView.Columns["Precio"].DefaultCellStyle.Format = "N2";
        }

        private async void btnEntrada_Click(object sender, EventArgs e)
        {
            var EForm = Program.ServiceProvider.GetRequiredService<CrearProductoForm>();
            EForm.ShowDialog();
            await LoadDataAsync();
        }

        private async void btnSalida_Click(object sender, EventArgs e)
        {
            var eForm = Program.ServiceProvider.GetRequiredService<EForm>();
            eForm.ShowDialog();
            await LoadDataAsync();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (productoDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro para modificar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entidad = (ListarModel)productoDataGridView.CurrentRow.DataBoundItem;

            var form = ActivatorUtilities.CreateInstance<ModificarInventarioForm>(
                Program.ServiceProvider, entidad);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _ = LoadDataAsync();
            }
        }

        private void btnELiminar_Click(object sender, EventArgs e)
        {
            if (productoDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entidad = (ListarModel)productoDataGridView.CurrentRow.DataBoundItem;

            string accion = _viendoInactivos ? "activar" : "desactivar";
            var result = MessageBox.Show(
                $"¿Desea {accion} el producto '{entidad.Nombre}'?",
                $"Confirmar {accion}", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _ = CambiarEstadoAsync(entidad);
            }
        }

        private async Task CambiarEstadoAsync(ListarModel entidad)
        {
            try
            {
                entidad.Activo = _viendoInactivos;
                entidad.FechaModificacion = DateTime.Now;
                var success = await _service.Modificar(entidad);

                if (success)
                {
                    MessageBox.Show($"Producto {(_viendoInactivos ? "activado" : "desactivado")} correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDataAsync();
                }
                else
                {
                    MessageBox.Show("No se pudo cambiar el estado del producto.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                var realMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Error al cambiar estado: {realMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnToggleVista_Click(object sender, EventArgs e)
        {
            _viendoInactivos = !_viendoInactivos;
            if (_viendoInactivos)
            {
                btnToggleVista.Text = "Ver Activos";
                btnELiminar.Text = "Activar";
                lbTituloList.Text = "Listar Productos Inactivos";
            }
            else
            {
                btnToggleVista.Text = "Ver Inactivos";
                btnELiminar.Text = "Desactivar";
                lbTituloList.Text = "Listar Productos";
            }
            await LoadDataAsync();
        }

        private async void txBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            try
            {
                // Esperar 400ms para evitar múltiples consultas mientras el usuario escribe (Debounce)
                await Task.Delay(400, token);
                if (token.IsCancellationRequested) return;

                // Esperar si hay otra consulta ejecutándose para evitar el error de DbContext
                while (_isSearching)
                {
                    await Task.Delay(50, token);
                    if (token.IsCancellationRequested) return;
                }

                _isSearching = true;

                string criterio = txBuscarProducto.Text.Trim();

                if (string.IsNullOrWhiteSpace(criterio))
                {
                    await LoadDataAsync();
                }
                else
                {
                    bool esNumero = int.TryParse(criterio, out int idBusqueda);

                    bool estadoBuscado = !_viendoInactivos;
                    var resultados = await _service.GetList(p =>
                        ((p.Activo ?? true) == estadoBuscado) &&
                        (p.Nombre.Contains(criterio) ||
                        p.CodigoBarras.Contains(criterio) ||
                        (esNumero && p.ProductoId == idBusqueda))
                    );

                    if (!token.IsCancellationRequested)
                    {
                        productoDataGridView.DataSource = resultados;
                    }
                }
            }
            catch (TaskCanceledException)
            {
                // Se ignora porque significa que el usuario siguió escribiendo
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar producto: {ex.Message}", "Error de Búsqueda",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isSearching = false;
            }
        }

        private async void lbSalidaProductoss_Click(object sender, EventArgs e)
        {
            var salidaProductos = Program.ServiceProvider.GetRequiredService<SForm>();
            salidaProductos.ShowDialog();
            await LoadDataAsync();
        }
    }
}
