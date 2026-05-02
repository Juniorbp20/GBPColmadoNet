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
                var productosParaMostrar = await _service.GetList(d => true);
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
            var EForm = Program.ServiceProvider.GetRequiredService<Forms.CrearProductoForm>();
            EForm.ShowDialog();
            await LoadDataAsync();
        }

        private async void btnSalida_Click(object sender, EventArgs e)
        {
            var SForm = Program.ServiceProvider.GetRequiredService<EForm>();
            SForm.ShowDialog();
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
                MessageBox.Show("Seleccione un registro para modificar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entidad = (ListarModel)productoDataGridView.CurrentRow.DataBoundItem;

            var result = MessageBox.Show(
                $"¿Desea eliminar el departamento '{entidad.Nombre}'?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _ = EliminarAsync(entidad.ProductoId);
            }
        }

        private async Task EliminarAsync(int id)
        {
            try
            {
                var success = await _service.Eliminar(id);

                if (success)
                {
                    MessageBox.Show("Departamento eliminado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDataAsync();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el departamento.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                    var resultados = await _service.GetList(p =>
                        p.Nombre.Contains(criterio) ||
                        p.CodigoBarras.Contains(criterio) ||
                        (esNumero && p.ProductoId == idBusqueda)
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
    }
}
