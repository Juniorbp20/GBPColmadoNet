using GBPColmadoNet.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet.UI.Forms.Inventario.ESForm
{
    public partial class ListarProductosList : Form
    {
        private readonly ColmadoContext _context;

        public ListarProductosList(ColmadoContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void lbTituloList_Click(object sender, EventArgs e)
        {

        }

        private void ESList_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var productos = await _context.Productos.ToListAsync();
                productoDataGridView.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            var EForm = Program.ServiceProvider.GetRequiredService<Forms.EForm>();
            EForm.ShowDialog();
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            var SForm = Program.ServiceProvider.GetRequiredService<SForm>();
            SForm.ShowDialog();
        }
    }
}
