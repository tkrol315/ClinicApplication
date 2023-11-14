using ClinicApp.DependencyInjection;
using ClinicApp.Entities;
using ClinicApp.Seeders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ClinicApp
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static IServiceProvider ServiceProvider { get; private set; }
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ServiceProvider = MainDependencyInjection.CreateHostBuilder().Build().Services;
            var seeder = ServiceProvider.GetRequiredService<SeederInit>();
            await seeder.Init();
            var form = ServiceProvider.GetRequiredService<LoginForm>();
            Application.Run(form);

        }

    }
}