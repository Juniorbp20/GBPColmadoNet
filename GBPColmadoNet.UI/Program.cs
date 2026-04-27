using GBPColmadoNet.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
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


namespace GBPColmadoNet;

     static class Program
    {
    public static ServiceProvider ServiceProvider { get; private set; }
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
        Application.Run(ServiceProvider.GetRequiredService<MainForm>());
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
        services.AddTransient<SList>();
        services.AddTransient<EForm>();
        services.AddTransient<ProveedorForm>();
        services.AddTransient<ProveedorList>();
        services.AddTransient<CuadreForm>();
        services.AddTransient<VentaRapidaForm>();
        services.AddTransient<ListarProductosList>();



        //Services 


    }
}