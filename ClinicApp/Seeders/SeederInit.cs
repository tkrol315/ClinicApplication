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
            await _serviceProvider.GetService<ScheduleSeeder>().Seed();
            await _serviceProvider.GetService<RequestStateSeeder>().Seed();
            //var list = _serviceProvider.GetServices<ISeeder>().ToList();
            //foreach (var item in list)
            //{
            //    await item.Seed();
            //}

        }
    }
}
