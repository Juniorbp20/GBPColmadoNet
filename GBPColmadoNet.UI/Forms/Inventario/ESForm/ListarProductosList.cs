using GBPColmadoNet.Data.Context;
using GBPColmadoNet.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet.UI.Forms.Inventario.ESForm
{
    public partial class ListarProductosList : Form
    {
        private readonly ProductoService _service;

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
    }
}
