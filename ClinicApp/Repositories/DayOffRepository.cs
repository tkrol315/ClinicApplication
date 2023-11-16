using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Repositories
{
    public class DayOffRepository : 
        RepositoryAsync<DayOff>, IDayOffRepository
    {
        public DayOffRepository(ClinicDbContext dbContext) : base(dbContext)
        {

        }

        public async Task AddRange(IEnumerable<DayOff> dayOffs)
        {
            await _dbContext.DaysOff.AddRangeAsync(dayOffs);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<DayOff>> GetAllDaysOffByUserId(int userId)
        {
            var user = await _dbContext.Users
                .Include(u => u.DaysOff)
                .SingleAsync(u => u.Id == userId);
            var daysOff = user.DaysOff;
            return daysOff;
        }
    }
}
