using GBPColmadoNet.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
            var service = new ServiceCollection();
            //ConfigureServices(service);

            var host = CreateHostBuilder().Build();

            using (var scope = host.Services.CreateScope())

            {
                var services = scope.ServiceProvider;
                
                try
                {
                    var mainForm = services.GetRequiredService<MainForm>();
                    Application.Run(mainForm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error crítico al iniciar: {ex.Message}", "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    var connectionString = context.Configuration.GetConnectionString("DefaultConnection");

                    services.AddDbContext<ColmadoContext>(options =>
                        options.UseSqlServer(connectionString));

                    services.AddTransient<MainForm>();
                });
}