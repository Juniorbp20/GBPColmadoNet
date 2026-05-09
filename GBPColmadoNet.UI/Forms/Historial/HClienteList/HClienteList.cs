using GBPColmadoNet.UI.Services;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace GBPColmadoNet.UI.Forms.Historial.HProveedorList
{
    public partial class HClienteList : Form
    {
        private readonly VentasService _ventasService;

        public HClienteList(VentasService ventasService)
        {
            InitializeComponent();
            _ventasService = ventasService;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await BuscarHistorial();
        }

        private async System.Threading.Tasks.Task BuscarHistorial()
        {
            string busqueda = txtBusquedaCliente.Text.Trim();
            
            Expression<Func<Data.Models.Venta, bool>> criterio;
            if (string.IsNullOrEmpty(busqueda))
            {
                criterio = v => true;
            }
            else
            {
                criterio = v => v.Cliente != null && (v.Cliente.Nombre.Contains(busqueda) || v.Cliente.ClienteId.ToString() == busqueda);
            }

            var ventas = await _ventasService.GetListWithDetails(criterio);
            
            var detalleHistorial = ventas.SelectMany(v => v.VentasDetalles.Select(vd => new 
            {
                Fecha = v.Fecha?.ToString("dd/MM/yyyy hh:mm tt") ?? "",
                Cliente = v.Cliente?.Nombre ?? "Consumidor Final",
                Producto = vd.Producto?.Nombre ?? "N/A",
                Cantidad = vd.Cantidad,
                PrecioUnitario = vd.PrecioUnitario.ToString("N2"),
                SubTotal = (vd.Cantidad * vd.PrecioUnitario).ToString("N2")
            })).OrderByDescending(d => d.Fecha).ToList();

            dgvHistorialCliente.DataSource = detalleHistorial;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusquedaCliente.Text = string.Empty;
            dgvHistorialCliente.DataSource = null;
            txtBusquedaCliente.Focus();
        }

        private async void HClienteList_Load(object sender, EventArgs e)
        {
            await BuscarHistorial();
        }
    }
}
