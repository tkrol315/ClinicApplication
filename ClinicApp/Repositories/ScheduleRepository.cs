using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp.Repositories
{
    public class ScheduleRepository : RepositoryAsync<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(ClinicDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Schedule>>GetSchedulesByUserId(int id)
        {
            var schedules = await _dbContext.Users
            .Where(u => u.Id == id)
            .SelectMany(u => u.Schedules)
            .OrderBy(s => s.Date)
            .ToListAsync();
            return schedules;
        }

        
    }
}
