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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var es = Program.ServiceProvider.GetRequiredService<UI.Forms.Inventario.ESForm.ListarProductosList>();
            es.Show();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var devoluciones = Program.ServiceProvider.GetRequiredService<UI.Forms.Inventario.Devoluciones.DevolucionesList>();
            devoluciones.Show();
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listarProductos = Program.ServiceProvider.GetRequiredService<UI.Forms.Inventario.ESForm.ListarProductosList>();
            listarProductos.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var listarProductos = Program.ServiceProvider.GetRequiredService<UI.Forms.Inventario.ESForm.ListarProductosList>();
            listarProductos.Show();
        }

        private void toolStripButtonDevoluciones_Click(object sender, EventArgs e)
        {
            var devoluciones = Program.ServiceProvider.GetRequiredService<UI.Forms.Inventario.Devoluciones.DevolucionesList>();
            devoluciones.Show();
        }

        private void toolStripButtonListarProductos_Click(object sender, EventArgs e)
        {
            var listarProductos = Program.ServiceProvider.GetRequiredService<UI.Forms.Inventario.ESForm.ListarProductosList>();
            listarProductos.Show();
        }
    }
}
