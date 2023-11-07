using ClinicApp.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.DependencyInjection
{
    public static class MainDependencyInjection
    {
        private static readonly string _connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public static IHostBuilder CreateHostBuilder()
        {

            return Host
                .CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddFormsToDependencyInjection();
                    services.AddSeedersDependencyInjection();
                    services.AddDbContext<ClinicDbContext>(options => options.UseSqlServer(_connectionString));
                    services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

                });
        }
    }
}
