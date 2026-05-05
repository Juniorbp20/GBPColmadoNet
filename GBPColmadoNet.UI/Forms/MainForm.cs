using GBPColmadoNet.Data.Context;
using GBPColmadoNet.UI.Forms.Clientes;
using GBPColmadoNet.UI.Forms.Clientes.FiaoForm;
using GBPColmadoNet.UI.Forms.Configuracion;
using GBPColmadoNet.UI.Forms.Historial.HProveedorList;
using GBPColmadoNet.UI.Forms.Historial.HVentasForm;
using GBPColmadoNet.UI.Forms.Inventario.Devoluciones;
using GBPColmadoNet.UI.Forms.Ventas;
using Microsoft.Extensions.DependencyInjection;
using ListarProductosList = GBPColmadoNet.UI.Forms.Inventario.ESForm.ListarProductosList;

namespace GBPColmadoNet
{
    public partial class MainForm : Form
    {

        public MainForm(ColmadoContext context)
        {
            InitializeComponent();
            ConfigurarMenuAcordeon();
        }

        private void ConfigurarMenuAcordeon()
        {
            toolStripButton1.Visible = false;
            toolStripButtonDevoluciones.Visible = false;
            toolStripButtonListarProductos.Visible = false;

            toolStripButtonVentaR.Visible = false;
            toolStripButtonCuadre.Visible = false;

            toolStripButtonCliente.Visible = false;
            toolStripButtonCuentasPCobrar.Visible = false;

            toolStripButtonHClientes.Visible = false;
            toolStripButtonHProveedor.Visible = false;
            toolStripButtonHVentas.Visible = false;

            tlSConfiguraciones.Visible = false;

            toolStripLabelInventario.Click += (s, e) =>
            {
                bool show = !toolStripButton1.Visible;
                toolStripButton1.Visible = show;
                toolStripButtonDevoluciones.Visible = show;
                toolStripButtonListarProductos.Visible = show;
            };

            toolStripLabelVentas.Click += (s, e) =>
            {
                bool show = !toolStripButtonVentaR.Visible;
                toolStripButtonVentaR.Visible = show;
                toolStripButtonCuadre.Visible = show;
            };

            toolStripLabelCliente.Click += (s, e) =>
            {
                bool show = !toolStripButtonCliente.Visible;
                toolStripButtonCliente.Visible = show;
                toolStripButtonCuentasPCobrar.Visible = show;
            };

            toolStripLabelHistorial.Click += (s, e) =>
            {
                bool show = !toolStripButtonHClientes.Visible;
                toolStripButtonHClientes.Visible = show;
                toolStripButtonHProveedor.Visible = show;
                toolStripButtonHVentas.Visible = show;
            };

            toolStripButtonConfiguracion.Click += (s, e) =>
            {
                bool show = !tlSConfiguraciones.Visible;
                tlSConfiguraciones.Visible = show;
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var es = Program.ServiceProvider?.GetRequiredService<ListarProductosList>();
            es?.Show();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var devoluciones = Program.ServiceProvider?.GetRequiredService<DevolucionesList>();
            devoluciones?.Show();
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listarProductos = Program.ServiceProvider?.GetRequiredService<ListarProductosList>();
            listarProductos?.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var listarProductos = Program.ServiceProvider?.GetRequiredService<ListarProductosList>();
            listarProductos?.Show();
        }

        private void toolStripButtonDevoluciones_Click(object sender, EventArgs e)
        {
            var devoluciones = Program.ServiceProvider?.GetRequiredService<DevolucionesList>();
            devoluciones?.Show();
        }

        private void toolStripButtonListarProductos_Click(object sender, EventArgs e)
        {
            var listarProductos = Program.ServiceProvider?.GetRequiredService<ListarProductosList>();
            listarProductos?.Show();
        }

        private void toolStripButtonVentaR_Click(object sender, EventArgs e)
        {
            var ventaRapida = Program.ServiceProvider.GetRequiredService<VentaRapidaForm>();
            ventaRapida?.ShowDialog();

        }

        private void ventaRapidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ventaRapida = Program.ServiceProvider.GetRequiredService<VentaRapidaForm>();
            ventaRapida?.ShowDialog();
        }

        private void cuadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cuadre = Program.ServiceProvider.GetRequiredService<CuadreForm>();
            cuadre.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cliente = Program.ServiceProvider.GetRequiredService<ClienteList>();
            cliente.ShowDialog();
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cuentasPorCobrar = Program.ServiceProvider.GetRequiredService<CuentasPorCobrarList>();
            cuentasPorCobrar.ShowDialog();
        }

        private void historialClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historialCliente = Program.ServiceProvider.GetRequiredService<HClienteList>();
            historialCliente.ShowDialog();
        }

        private void historialProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historialProveedor = Program.ServiceProvider.GetRequiredService<HProveedorList>();
            historialProveedor.ShowDialog();
        }

        private void historialVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historialVentas = Program.ServiceProvider.GetRequiredService<HVentasList>();
            historialVentas.ShowDialog();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var configuracion = Program.ServiceProvider.GetRequiredService<ConfiguracionForm>();
            configuracion.ShowDialog();
        }
    }
}
