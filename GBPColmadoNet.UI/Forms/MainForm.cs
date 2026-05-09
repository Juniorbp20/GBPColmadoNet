using GBPColmadoNet.Data.Context;
using GBPColmadoNet.UI.Forms.Clientes;
using GBPColmadoNet.UI.Forms.Clientes.CuentasPorCobrar;
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

        private System.Windows.Forms.Timer _timer;

        public MainForm(ColmadoContext context)
        {
            InitializeComponent();
            ConfigurarMenuAcordeon();

            toolStrip1.Renderer = new CustomToolStripRenderer();

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
            _timer.Start();

            cerrarSesionToolStripMenuItem.Click += CerrarSesion_Click;
            tlSCerrarSesion.Click += CerrarSesion_Click;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (lblClock != null) lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (lblDate != null) lblDate.Text = DateTime.Now.ToString("dddd, d 'de' MMMM 'de' yyyy");
        }

        private void CerrarSesion_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var currentUser = GBPColmadoNet.UI.Services.SessionManager.CurrentUser;
            if (currentUser != null && currentUser.Rol != "Admin")
            {
                var cierreCajaService = Program.ServiceProvider.GetRequiredService<GBPColmadoNet.UI.Services.CierreCajaService>();

                var cajaAbierta = Task.Run(() => cierreCajaService.ObtenerCajaAbiertaAsync(currentUser.UsuarioId)).Result;

                if (cajaAbierta != null)
                {
                    MessageBox.Show("No puede cerrar el sistema ni la sesión sin antes realizar el cuadre de caja.", "Caja Abierta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                    return;
                }
            }
            base.OnFormClosing(e);
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

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await CargarDashboard();
        }

        private async Task CargarDashboard()
        {
            try
            {
                var context = Program.ServiceProvider.GetRequiredService<ColmadoContext>();
                var configService = Program.ServiceProvider.GetRequiredService<UI.Services.ConfiguracionService>();

                // 1. Configuracion del negocio (Header)
                var config = await configService.ObtenerConfiguracionAsync();
                if (config != null)
                {
                    string nombreNegocio = string.IsNullOrEmpty(config.NombreComercial) ? "GBPColmadoNet" : config.NombreComercial;
                    lblBrandTitle.Text = nombreNegocio;
                    this.Text = $"Sistema Colmado {nombreNegocio}";
                    lblBrandSub.Text = string.IsNullOrEmpty(config.Descripcion) ? "Gestiona tu inventario, ventas y proveedores desde un solo lugar" : config.Descripcion;
                }

                // 2. Usuario Actual
                var currentUser = GBPColmadoNet.UI.Services.SessionManager.CurrentUser;
                if (currentUser != null)
                {
                    lblBienvenido.Text = $"Bienvenido {currentUser.Username} ({currentUser.Rol})";
                }

                // 3. Stats
                // Productos activos
                var productosActivos = context.Productos.Count(p => p.Activo == true);
                lblProductosActivosValue.Text = productosActivos.ToString();

                // Proveedores eliminados de la vista principal

                // Stock critico (<= 5)
                var stockCritico = context.Productos.Count(p => p.Stock <= 5 && p.Activo == true);
                lblStockCriticoValue.Text = stockCritico.ToString();

                // Venta Total hoy
                var ventasHoy = context.Ventas
                    .Where(v => v.Fecha.HasValue && v.Fecha.Value.Date == DateTime.Today)
                    .Sum(v => (decimal?)v.TotalNeto + (decimal?)v.TotalItbis) ?? 0m;
                lblVentaTotalValue.Text = ventasHoy.ToString("N2");

                // Ganancia estimada de hoy
                var detallesHoy = context.VentasDetalles
                    .Where(d => d.Venta != null && d.Venta.Fecha.HasValue && d.Venta.Fecha.Value.Date == DateTime.Today)
                    .Select(d => new
                    {
                        d.Cantidad,
                        d.PrecioUnitario,
                        PrecioCompra = d.Producto != null ? d.Producto.PrecioCompra : 0
                    }).ToList();

                decimal gananciaHoy = detallesHoy.Sum(d => (d.PrecioUnitario - d.PrecioCompra) * d.Cantidad);
                lblGananciaEstimadaValue.Text = gananciaHoy.ToString("N2");

                // Fiados pendientes
                var fiadosPendientes = context.CuentasPorCobrars
                    .Where(c => c.Estado == "Pendiente")
                    .Sum(c => (decimal?)c.MontoDeuda - (decimal?)(c.MontoAbonado ?? 0m)) ?? 0m;
                lblFiadosPendientesValue.Text = fiadosPendientes.ToString("N2");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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

        private async void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var configuracion = Program.ServiceProvider.GetRequiredService<ConfiguracionForm>();
            configuracion.ShowDialog();
            await CargarDashboard();
        }

        private void toolStripButtonCuadre_Click(object sender, EventArgs e)
        {
            var cuadre = Program.ServiceProvider.GetRequiredService<CuadreForm>();
            cuadre.ShowDialog();
        }

        private void toolStripButtonCliente_Click(object sender, EventArgs e)
        {
            var cliente = Program.ServiceProvider.GetRequiredService<ClienteList>();
            cliente.ShowDialog();
        }

        private void toolStripButtonCuentasPCobrar_Click(object sender, EventArgs e)
        {
            var cuentasPorCobrar = Program.ServiceProvider.GetRequiredService<CuentasPorCobrarList>();
            cuentasPorCobrar.ShowDialog();
        }

        private void toolStripButtonHClientes_Click(object sender, EventArgs e)
        {
            var historialCliente = Program.ServiceProvider.GetRequiredService<HClienteList>();
            historialCliente.ShowDialog();
        }

        private void toolStripButtonHProveedor_Click(object sender, EventArgs e)
        {
            var historialProveedor = Program.ServiceProvider.GetRequiredService<HProveedorList>();
            historialProveedor.ShowDialog();
        }

        private void toolStripButtonHVentas_Click(object sender, EventArgs e)
        {
            var historialVentas = Program.ServiceProvider.GetRequiredService<HVentasList>();
            historialVentas.ShowDialog();
        }

        private async void tlSConfiguraciones_Click(object sender, EventArgs e)
        {
            var configuracion = Program.ServiceProvider.GetRequiredService<ConfiguracionForm>();
            configuracion.ShowDialog();
            await CargarDashboard();
        }

        private void tlSCerrarSesion_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
