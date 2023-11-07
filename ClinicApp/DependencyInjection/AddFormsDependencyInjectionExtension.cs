using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.DependencyInjection
{
    static public class AddFormsDependencyInjectionExtension
    {
        public static IServiceCollection AddFormsToDependencyInjection(this IServiceCollection services)
        {
            var forms = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(x => x.IsSubclassOf(typeof(Form)))
                .ToList();

            foreach (var form in forms)
            {
                services.AddTransient(form);
            }

            return services;
        }
    }

}
