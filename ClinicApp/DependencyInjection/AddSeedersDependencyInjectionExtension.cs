using ClinicApp.Seeders;
using ClinicApp.Seeders.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.DependencyInjection
{
    public static class AddSeedersDependencyInjectionExtension
    {
        public static IServiceCollection AddSeedersDependencyInjection(this IServiceCollection service)
        {
            var seeders = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => typeof(ISeeder).IsAssignableFrom(x) 
                && !x.IsInterface
                && !x.IsAbstract)
                .ToList();
            foreach (var seeder in seeders)
            {
                service.AddTransient(seeder);
            }
            service.AddTransient<SeederInit>();
            return service;
        }
    }
}
