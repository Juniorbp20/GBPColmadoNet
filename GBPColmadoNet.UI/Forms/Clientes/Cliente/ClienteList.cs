using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet.UI.Forms.Clientes
{
    public partial class ClienteList : Form
    {
        private readonly ClienteService _service;
        private CancellationTokenSource? _cancellationTokenSource;
        private bool _isSearching = false;

        public ClienteList(ClienteService service)
        {
            InitializeComponent();
            _service = service;
        }

        private async void ClienteList_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var clientes = await _service.GetList(c => true);
                clienteDataGridView.DataSource = null;
                clienteDataGridView.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error de Carga",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<ClienteForm>();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _ = LoadDataAsync();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (clienteDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro para modificar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entidad = (Cliente)clienteDataGridView.CurrentRow.DataBoundItem!;

            var form = ActivatorUtilities.CreateInstance<ClienteForm>(
                Program.ServiceProvider, entidad!);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _ = LoadDataAsync();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var entidad = (Cliente)clienteDataGridView.CurrentRow.DataBoundItem!;

            var result = MessageBox.Show(
                $"¿Desea eliminar el cliente '{entidad.Nombre}'?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await EliminarAsync(entidad.ClienteId);
            }
        }

        private async Task EliminarAsync(int id)
        {
            try
            {
                var success = await _service.Eliminar(id);

                if (success)
                {
                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDataAsync();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el cliente.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void txBuscarCliente_TextChanged(object sender, EventArgs e)
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

                string criterio = txBuscarCliente.Text.Trim();

                if (string.IsNullOrWhiteSpace(criterio))
                {
                    await LoadDataAsync();
                }
                else
                {
                    bool esNumero = int.TryParse(criterio, out int idBusqueda);

                    var resultados = await _service.GetList(c =>
                        c.Nombre.Contains(criterio) ||
                        (esNumero && c.ClienteId == idBusqueda)
                    );

                    if (!token.IsCancellationRequested)
                    {
                        clienteDataGridView.DataSource = resultados;
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