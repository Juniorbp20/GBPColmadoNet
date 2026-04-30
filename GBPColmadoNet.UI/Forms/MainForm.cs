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
using ListarProductosList = GBPColmadoNet.UI.Forms.Inventario.ListarProductos.ListarProductosList;

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
            // Ocultar sub-botones al inicio
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

            // Manejar clics en los labels para mostrar/ocultar
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
            var es = Program.ServiceProvider?.GetRequiredService<UI.Forms.Inventario.ESForm.ListarProductosList>();
            es?.Show();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var devoluciones = Program.ServiceProvider?.GetRequiredService<UI.Forms.Inventario.Devoluciones.DevolucionesList>();
            devoluciones?.Show();
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listarProductos = Program.ServiceProvider?.GetRequiredService<UI.Forms.Inventario.ESForm.ListarProductosList>();
            listarProductos?.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var listarProductos = Program.ServiceProvider?.GetRequiredService<UI.Forms.Inventario.ESForm.ListarProductosList>();
            listarProductos?.Show();
        }

        private void toolStripButtonDevoluciones_Click(object sender, EventArgs e)
        {
            var devoluciones = Program.ServiceProvider?.GetRequiredService<UI.Forms.Inventario.Devoluciones.DevolucionesList>();
            devoluciones?.Show();
        }

        private void toolStripButtonListarProductos_Click(object sender, EventArgs e)
        {
            var listarProductos = Program.ServiceProvider?.GetRequiredService<UI.Forms.Inventario.ESForm.ListarProductosList>();
            listarProductos?.Show();
        }
    }
}
