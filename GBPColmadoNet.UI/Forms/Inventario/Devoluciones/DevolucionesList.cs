using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet.UI.Forms.Inventario.Devoluciones
{
    public partial class DevolucionesList : Form
    {
        private readonly DevolucionService _service;
        private CancellationTokenSource _cancellationTokenSource;
        private bool _isSearching = false;

        public DevolucionesList(DevolucionService service)
        {
            InitializeComponent();
            _service = service;
        }

        private async void DevolucionesList_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var devoluciones = await _service.GetList(d => true);
                devolucionDataGridView.DataSource = null;
                devolucionDataGridView.DataSource = devoluciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error de Carga",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<DevolucionesForm>();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _ = LoadDataAsync();
            }
        }

        private async void txBuscarDevolucion_TextChanged(object sender, EventArgs e)
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

                string criterio = txBuscarDevolucion.Text.Trim();

                if (string.IsNullOrWhiteSpace(criterio))
                {
                    await LoadDataAsync();
                }
                else
                {
                    var resultados = await _service.GetList(d =>
                        d.ProductoNombre.Contains(criterio) ||
                        d.Motivo.Contains(criterio)
                    );

                    if (!token.IsCancellationRequested)
                    {
                        devolucionDataGridView.DataSource = resultados;
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