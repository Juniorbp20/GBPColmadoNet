using GBPColmadoNet.Data.Context;
using GBPColmadoNet.Data.Models;
using GBPColmadoNet.UI.Forms;
using GBPColmadoNet.UI.Forms.Clientes;
using GBPColmadoNet.UI.Forms.Clientes.FiaoForm;
using GBPColmadoNet.UI.Forms.Configuracion;
using GBPColmadoNet.UI.Forms.Historial.HProveedorList;
using GBPColmadoNet.UI.Forms.Historial.HVentasForm;
using GBPColmadoNet.UI.Forms.Inventario.Devoluciones;
using GBPColmadoNet.UI.Forms.Inventario.ESForm;
using GBPColmadoNet.UI.Forms.Inventario.ListarProductos;
using GBPColmadoNet.UI.Forms.Proveedor;
using GBPColmadoNet.UI.Forms.Ventas;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet
{
    public partial class MainForm : Form
    {

        public MainForm(ColmadoContext context)
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ventaRapida = Program.ServiceProvider.GetRequiredService<VentaRapidaForm>();
            ventaRapida.Show();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCatInicio_Click(object sender, EventArgs e)
        {
            //var InicioForm = Program.ServiceProvider.GetRequiredService<MainForm>();
            //InicioForm.Show();
        }

        private void btnEntradaSalida_Click(object sender, EventArgs e)
        {
            var eS = Program.ServiceProvider.GetRequiredService<SList>();
            eS.Show();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            var devoluciones = Program.ServiceProvider.GetRequiredService<DevolucionesList>();
            devoluciones.Show();
        }

        private void btnCuadre_Click(object sender, EventArgs e)
        {
            var cuadre = Program.ServiceProvider.GetRequiredService<CuadreForm>();
            cuadre.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var cliente = Program.ServiceProvider.GetRequiredService<ClienteList>();
            cliente.Show();
        }

        private void btnCuentaPorPagar_Click(object sender, EventArgs e)
        {
            var cuentaPorCobrar = Program.ServiceProvider.GetRequiredService<CuentasPorCobrarList>();
            cuentaPorCobrar.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            var proveedor = Program.ServiceProvider.GetRequiredService<ProveedorList>();
            proveedor.Show();
        }

        private void BtnHVentas_Click(object sender, EventArgs e)
        {
            var hVentas = Program.ServiceProvider.GetRequiredService<HVentasList>();
            hVentas.Show();
        }

        private void btnHClientes_Click(object sender, EventArgs e)
        {
            var hClientes = Program.ServiceProvider.GetRequiredService<HClienteList>();
            hClientes.Show();
        }

        private void btnHProveedor_Click(object sender, EventArgs e)
        {
            var hProveedor = Program.ServiceProvider.GetRequiredService<HProveedorList>();
            hProveedor.Show();
        }

        private void btnCatConfig_Click(object sender, EventArgs e)
        {
            var configuracion = Program.ServiceProvider.GetRequiredService<ConfiguracionForm>();
            configuracion.Show();
        }

        private void btnCatCerrarSesion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            var listarProductos = Program.ServiceProvider.GetRequiredService<ListarProductosList>();
            listarProductos.Show();
        }
    }
}
