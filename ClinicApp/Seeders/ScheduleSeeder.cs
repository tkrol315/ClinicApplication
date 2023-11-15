using Bogus;
using ClinicApp.Entities;
using ClinicApp.Enums;
using ClinicApp.Seeders.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp.Seeders
{
    public class ScheduleSeeder : ISeeder
    {
        private readonly ClinicDbContext _dbContext;
        private List<Schedule> _schedules;
        public ScheduleSeeder(ClinicDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Seed()
        {
           if(!_dbContext.Schedules.Any())
            {
                GenerateSchedules(70);
                await LinkUsersWithSchedules(50);
                await _dbContext.SaveChangesAsync();

            }
        }

        private void GenerateSchedules(int schedulesToGen)
        {
            var startDate = new DateTime(2023, 12, 10);
            var endDate = new DateTime(2024, 2, 25);

            var scheduleGenerator = new Faker<Schedule>()
                .RuleFor(s => s.Date, f => f.Date.Between(startDate, endDate).Date)
                .RuleFor(s => s.TimeOfDay, f => f.PickRandom<TimeOfDay>());

            HashSet<DateTime> generatedDates = new HashSet<DateTime>();
            List<Schedule> schedules = new List<Schedule>();

            for (int i = 0; i < schedulesToGen;)
            {
                var generatedSchedule = scheduleGenerator.Generate();

                if (generatedDates.Add(generatedSchedule.Date))
                {
                    schedules.Add(generatedSchedule);
                    i++;
                }
            }

            _schedules = schedules;
        }   


        private async Task LinkUsersWithSchedules(int schedulesPerUser)
        {
            var users = await _dbContext.Users.Include(u => u.Schedules).Where(u => u.RoleId == 1).ToListAsync();

            var random = new Random();

            foreach (var user in users)
            {
                var numbers = new HashSet<int>();

                for (int i = 0; i < schedulesPerUser; i++)
                {
                    int number;
                    do
                    {
                        number = random.Next(0, _schedules.Count);
                    } while (numbers.Contains(number));

                    numbers.Add(number);
                    user.Schedules.Add(_schedules[number]);
                }
            }
        }
    }
}
