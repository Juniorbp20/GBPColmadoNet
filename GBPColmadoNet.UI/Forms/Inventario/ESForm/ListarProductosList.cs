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

        private async void ESList_Load(object sender, EventArgs e)
        {
           await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var productosParaMostrar = await _context.Productos
                    .Include(p => p.Categoria)
                    .Include(p => p.Proveedor)
                    .Select(p => new
                    {
                        ID = p.ProductoId,
                        Código = p.CodigoBarras,
                        Producto = p.Nombre,
                        Precio = p.PrecioVenta,
                        Existencia = p.Stock,
                        Categoría = p.Categoria != null ? p.Categoria.Nombre : "Sin Categoría",
                        Proveedor = p.Proveedor != null ? p.Proveedor.Nombre : "Sin Proveedor",
                        Estado = (bool)p.Activo ? "Activo" : "Inactivo"
                    })
                    .ToListAsync<object>();

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
