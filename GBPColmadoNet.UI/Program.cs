using GBPColmadoNet.Data.Context;
using GBPColmadoNet.UI.Forms;
using GBPColmadoNet.UI.Forms.Clientes;
using GBPColmadoNet.UI.Forms.Clientes.FiaoForm;
using GBPColmadoNet.UI.Forms.Configuracion;
using GBPColmadoNet.UI.Forms.Historial.HProveedorList;
using GBPColmadoNet.UI.Forms.Historial.HVentasForm;
using GBPColmadoNet.UI.Forms.Inventario.Devoluciones;
using GBPColmadoNet.UI.Forms.Inventario.ESForm;
using GBPColmadoNet.UI.Forms.LoginForm;
using GBPColmadoNet.UI.Forms.Proveedor;
using GBPColmadoNet.UI.Forms.Ventas;
using GBPColmadoNet.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GBPColmadoNet;

static class Program
{
    public static ServiceProvider ServiceProvider { get; private set; } = null!;
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        var services = new ServiceCollection();
        ConfigureServices(services);

        ServiceProvider = services.BuildServiceProvider();
        
        var loginForm = ServiceProvider.GetRequiredService<GBPColmadoNet.UI.Forms.LoginForm.LoginForm>();
        if (loginForm.ShowDialog() == DialogResult.OK)
        {
            var cierreCajaService = ServiceProvider.GetRequiredService<CierreCajaService>();
            var currentUser = SessionManager.CurrentUser;
            
            // Requerir caja abierta
            if (currentUser != null)
            {
                var cajaAbierta = cierreCajaService.ObtenerCajaAbiertaAsync(currentUser.UsuarioId).Result;
                if (cajaAbierta == null)
                {
                    var aperturaForm = ServiceProvider.GetRequiredService<GBPColmadoNet.UI.Forms.Ventas.AperturaCajaForm>();
                    if (aperturaForm.ShowDialog() != DialogResult.OK)
                    {
                        Application.Exit();
                        return;
                    }
                }
            }

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }
        else
        {
            Application.Exit();
        }
    }

    private static void ConfigureServices(ServiceCollection services)
    {

        var connectionString = System.Configuration.ConfigurationManager
            .ConnectionStrings["GBPColmado"].ConnectionString;

        services.AddDbContext<ColmadoContext>(options =>
            options.UseSqlServer(connectionString, sqlServerOptionsAction: sqlOptions =>
            {
                sqlOptions.EnableRetryOnFailure();
            }));

        //Form y List
        services.AddTransient<LoginForm>();
        services.AddTransient<GBPColmadoNet.UI.Forms.Ventas.AperturaCajaForm>();
        services.AddTransient<MainForm>();
        services.AddTransient<ClienteForm>();
        services.AddTransient<ClienteList>();
        services.AddTransient<CuentasPorCobrarList>();
        services.AddTransient<ConfiguracionForm>();
        services.AddTransient<HClienteList>();
        services.AddTransient<HProveedorList>();
        services.AddTransient<HVentasList>();
        services.AddTransient<DevolucionesForm>();
        services.AddTransient<DevolucionesList>();
        services.AddTransient<ListarProductosList>();
        services.AddTransient<CrearProductoForm>();
        services.AddTransient<ProveedorForm>();
        services.AddTransient<ProveedorList>();
        services.AddTransient<CuadreForm>();
        services.AddTransient<VentaRapidaForm>();
        services.AddTransient<EForm>();
        services.AddTransient<ModificarInventarioForm>();
        services.AddTransient<SForm>();

        //Services 
        services.AddTransient<ProductoService>();
        services.AddTransient<AbonoService>();
        services.AddTransient<BitacoraService>();
        services.AddTransient<CategoriaService>();
        services.AddTransient<CierreCajaService>();
        services.AddTransient<ClienteService>();
        services.AddTransient<ComprasService>();
        services.AddTransient<CuentasPorCobrarService>();
        services.AddTransient<ProveedorService>();
        services.AddTransient<RoleService>();
        services.AddTransient<UsuarioServices>();
        services.AddTransient<VentasService>();
        services.AddTransient<CarritoItemService>();
        services.AddTransient<ConfiguracionService>();
        services.AddTransient<DevolucionService>();


    }
}