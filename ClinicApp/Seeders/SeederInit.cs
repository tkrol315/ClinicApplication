using ClinicApp.Entities;
using ClinicApp.Migrations;
using ClinicApp.Seeders.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Seeders
{
    public class SeederInit
    {
        private readonly IServiceProvider _serviceProvider;

        public SeederInit(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public async Task Init()
        {
           await _serviceProvider.GetService<RoleSeeder>().Seed();
           await _serviceProvider.GetService<UserSeeder>().Seed();
           await _serviceProvider.GetService<DayOffTypeSeeder>().Seed();

        }
    }
}
