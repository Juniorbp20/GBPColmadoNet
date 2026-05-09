using GBPColmadoNet.UI.Services;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace GBPColmadoNet.UI.Forms.Historial.HProveedorList
{
    public partial class HProveedorList : Form
    {
        private readonly ProductoService _productoService;

        public HProveedorList(ProductoService productoService)
        {
            InitializeComponent();
            _productoService = productoService;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await BuscarHistorial();
        }

        private async System.Threading.Tasks.Task BuscarHistorial()
        {
            string busqueda = txtBusquedaProveedor.Text.Trim();
            
            Expression<Func<Data.Models.Producto, bool>> criterio;
            if (string.IsNullOrEmpty(busqueda))
            {
                criterio = p => true;
            }
            else
            {
                criterio = p => p.Proveedor != null && (p.Proveedor.Nombre.Contains(busqueda) || p.Proveedor.ProveedorId.ToString() == busqueda);
            }

            var productos = await _productoService.GetListWithDetails(criterio);
            
            var detalleHistorial = productos.Select(p => new 
            {
                ID = p.ProductoId,
                Codigo = p.CodigoBarras,
                Producto = p.Nombre,
                Proveedor = p.Proveedor?.Nombre ?? "N/A",
                Categoria = p.Categoria?.Nombre ?? "N/A",
                PrecioCompra = p.PrecioCompra.ToString("N2"),
                PrecioVenta = p.PrecioVenta.ToString("N2"),
                Stock = (p.Stock ?? 0m).ToString("N2")
            }).OrderBy(p => p.Producto).ToList();

            dgvHistorialProveedor.DataSource = detalleHistorial;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusquedaProveedor.Text = string.Empty;
            dgvHistorialProveedor.DataSource = null;
            txtBusquedaProveedor.Focus();
        }

        private async void HProveedorList_Load(object sender, EventArgs e)
        {
            await BuscarHistorial();
        }
    }
}
