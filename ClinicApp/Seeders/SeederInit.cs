using ClinicApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ClinicApp.Seeders
{
    public class SeederInit
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ClinicDbContext _dbContext;
        public SeederInit(IServiceProvider serviceProvider, ClinicDbContext dbContext)
        {
            _serviceProvider = serviceProvider;
            _dbContext = dbContext;
        }
        public async Task Init()
        {
            if (!_dbContext.Database.CanConnect())
            {
                await _dbContext.Database.MigrateAsync();
            }
            await _serviceProvider.GetService<RoleSeeder>().Seed();
            await _serviceProvider.GetService<UserSeeder>().Seed();
            await _serviceProvider.GetService<DayOffTypeSeeder>().Seed();
            await _serviceProvider.GetService<ScheduleSeeder>().Seed();
            await _serviceProvider.GetService<RequestStateSeeder>().Seed();

        }
    }
}
