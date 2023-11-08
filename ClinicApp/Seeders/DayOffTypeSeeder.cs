using ClinicApp.Entities;
using ClinicApp.Seeders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Seeders
{
    public class DayOffTypeSeeder : ISeeder
    {
        private readonly ClinicDbContext _dbContext;

        public DayOffTypeSeeder(ClinicDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Seed()
        {
            if (!_dbContext.DayOffTypes.Any())
            {
                var dayOfftypes = GetDayOffTypes();
                _dbContext.DayOffTypes.AddRange(dayOfftypes);
                await _dbContext.SaveChangesAsync();
            }
        }
        public IEnumerable<DayOffType> GetDayOffTypes()
        {
            var dayOffTypes = new List<DayOffType>()
            {
                new DayOffType()
                {
                    Name = "Urlop"
                },
                new DayOffType()
                {
                    Name = "L4"
                },
                new DayOffType()
                {
                    Name = "Urlop na żądanie"
                }
            };
            return dayOffTypes;
        }
    }
}
