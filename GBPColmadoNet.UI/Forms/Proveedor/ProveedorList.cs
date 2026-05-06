using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet.UI.Forms.Proveedor
{
    public partial class ProveedorList : Form
    {
        private readonly ProveedorService _service;
        private CancellationTokenSource _cancellationTokenSource;
        private bool _isSearching = false;

        public ProveedorList(ProveedorService service)
        {
            InitializeComponent();
            _service = service;
        }

        private async void ProveedorList_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var proveedores = await _service.GetList(p => true);
                proveedorDataGridView.DataSource = null;
                proveedorDataGridView.DataSource = proveedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error de Carga",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearProveedor_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<ProveedorForm>();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _ = LoadDataAsync();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (proveedorDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro para modificar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entidad = (Proveedore)proveedorDataGridView.CurrentRow.DataBoundItem;
            var form = Program.ServiceProvider.GetRequiredService<ProveedorForm>();

            var formConParametro = ActivatorUtilities.CreateInstance<ProveedorForm>(
                Program.ServiceProvider, entidad);

            if (formConParametro.ShowDialog(this) == DialogResult.OK)
            {
                _ = LoadDataAsync();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (proveedorDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entidad = (Proveedore)proveedorDataGridView.CurrentRow.DataBoundItem;

            var result = MessageBox.Show(
                $"¿Desea eliminar el proveedor '{entidad.Nombre}'?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await EliminarAsync(entidad.ProveedorId);
            }
        }

        private async Task EliminarAsync(int id)
        {
            try
            {
                var success = await _service.Eliminar(id);

                if (success)
                {
                    MessageBox.Show("Proveedor eliminado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDataAsync();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el proveedor.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void txBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            _cancellationTokenSource = new CancellationTokenSource();
            var token = _cancellationTokenSource.Token;

            try
            {
                await Task.Delay(400, token);
                if (token.IsCancellationRequested) return;

                while (_isSearching)
                {
                    await Task.Delay(50, token);
                    if (token.IsCancellationRequested) return;
                }

                _isSearching = true;

                string criterio = txBuscarProveedor.Text.Trim();

                if (string.IsNullOrWhiteSpace(criterio))
                {
                    await LoadDataAsync();
                }
                else
                {
                    bool esNumero = int.TryParse(criterio, out int idBusqueda);

                    var resultados = await _service.GetList(p =>
                        p.Nombre.Contains(criterio) ||
                        (esNumero && p.ProveedorId == idBusqueda)
                    );

                    if (!token.IsCancellationRequested)
                    {
                        proveedorDataGridView.DataSource = resultados;
                    }
                }
            }
            catch (TaskCanceledException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error de Búsqueda",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isSearching = false;
            }
        }
    }
}