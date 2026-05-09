using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet.UI.Forms.Clientes.CuentasPorCobrar
{
    public partial class CuentasPorCobrarList : Form
    {
        private readonly CuentasPorCobrarService _service;
        private CancellationTokenSource? _cancellationTokenSource;
        private bool _isSearching = false;

        public CuentasPorCobrarList(CuentasPorCobrarService service)
        {
            InitializeComponent();
            _service = service;
            cuentaDataGridView.CellFormatting += CuentaDataGridView_CellFormatting;
        }

        private void CuentaDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;
            if (cuentaDataGridView.Columns[e.ColumnIndex] == null) return;

            var columnName = cuentaDataGridView.Columns[e.ColumnIndex].Name;

            if (columnName == "Cliente")
            {
                if (e.Value is Cliente cliente)
                {
                    e.Value = cliente.Nombre;
                    e.FormattingApplied = true;
                }
            }
            else if (columnName == "Venta")
            {
                if (e.Value is Venta venta)
                {
                    e.Value = $"#{venta.VentaId} - {venta.Fecha:dd/MM/yyyy}";
                    e.FormattingApplied = true;
                }
            }
        }

        private async void CuentasPorCobrarList_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var cuentas = await _service.GetList(c => true);
                cuentaDataGridView.DataSource = null;
                cuentaDataGridView.DataSource = cuentas;

                if (cuentaDataGridView.Columns["Cliente"] is DataGridViewTextBoxColumn colCliente)
                {
                    colCliente.HeaderText = "Cliente";
                }
                if (cuentaDataGridView.Columns["MontoDeuda"] is DataGridViewTextBoxColumn colMontoDeuda)
                {
                    colMontoDeuda.DefaultCellStyle.Format = "N2";
                }
                if (cuentaDataGridView.Columns["MontoAbonado"] is DataGridViewTextBoxColumn colMontoAbonado)
                {
                    colMontoAbonado.DefaultCellStyle.Format = "N2";
                }
                if (cuentaDataGridView.Columns["BalancePendiente"] is DataGridViewTextBoxColumn colBalancePendiente)
                {
                    colBalancePendiente.DefaultCellStyle.Format = "N2";
                }
                if (cuentaDataGridView.Columns["FechaRegistro"] is DataGridViewTextBoxColumn colFechaRegistro)
                {
                    colFechaRegistro.DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                if (cuentaDataGridView.Columns["FechaVencimiento"] is DataGridViewTextBoxColumn colFechaVencimiento)
                {
                    colFechaVencimiento.DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                string[] colsToHide = { "ClienteId", "VentaId", "FechaModificacion", "Abonos" };
                foreach (var colName in colsToHide)
                {
                    if (cuentaDataGridView.Columns[colName] is DataGridViewColumn col)
                        col.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error de Carga",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            var form = Program.ServiceProvider.GetRequiredService<CuentasPorCobrarForm>();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _ = LoadDataAsync();
            }
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            if (cuentaDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cuenta para abonar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cuenta = (Data.Models.CuentasPorCobrar)cuentaDataGridView.CurrentRow!.DataBoundItem!;
            AbrirFormAbono(cuenta.Id);
        }

        private void cuentaDataGridView_DoubleClick(object? sender, EventArgs e)
        {
            if (cuentaDataGridView.CurrentRow == null)
                return;

            var cuenta = (Data.Models.CuentasPorCobrar)cuentaDataGridView.CurrentRow.DataBoundItem!;
            AbrirFormAbono(cuenta.Id);
        }

        private async void AbrirFormAbono(int cuentaId)
        {
            var cuenta = await _service.Buscar(cuentaId);
            if (cuenta == null)
            {
                MessageBox.Show("No se pudo cargar la cuenta.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = Program.ServiceProvider.GetRequiredService<CuentasPorCobrarForm>();
            var formConParametro = ActivatorUtilities.CreateInstance<CuentasPorCobrarForm>(
                Program.ServiceProvider, cuenta);

            if (formConParametro.ShowDialog(this) == DialogResult.OK)
            {
                _ = LoadDataAsync();
            }
        }

        private async void txBuscarCuenta_TextChanged(object sender, EventArgs e)
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

                string criterio = txBuscarCuenta.Text.Trim();

                if (string.IsNullOrWhiteSpace(criterio))
                {
                    await LoadDataAsync();
                }
                else
                {
                    var resultados = await _service.GetList(c =>
                        c.Cliente.Nombre.Contains(criterio) ||
                        (c.Estado != null && c.Estado.Contains(criterio))
                    );

                    if (!token.IsCancellationRequested)
                    {
                        cuentaDataGridView.DataSource = resultados;
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