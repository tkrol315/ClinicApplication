using ClinicApp.Entities;
using ClinicApp.Seeders.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace ClinicApp.Seeders
{
    public class UserSeeder : ISeeder
    {
        private readonly ClinicDbContext _dbContext;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserSeeder(ClinicDbContext dbContext, IPasswordHasher<User> passwordHasher)
        {
            _dbContext = dbContext;
            _passwordHasher = passwordHasher;
        }

        public async Task Seed()
        {
            if (!_dbContext.Users.Any())
            {
                var users = GetUsers();
                _dbContext.Users.AddRange(users);
                await _dbContext.SaveChangesAsync();
            }
        }

        private IEnumerable<User> GetUsers()
        {
            var users = new List<User>()
            {
              
                new User()
                {
                    Name = "ReceptionistName",
                    Surname = "ReceptionistSurname",
                    Login = "Receptionist",
                    PasswordHash = "",
                    DaysOffPull = 26,
                    RoleId = 2,
                },
                 new User()
                {
                    Name = "ManagerName",
                    Surname = "ManagerSurname",
                    Login = "Manager",
                    PasswordHash = "",
                    DaysOffPull = 26,
                    RoleId = 3,
                },
                   new User()
                {
                    Name = "AdminName",
                    Surname = "AdminSurname",
                    Login = "Admin",
                    PasswordHash = "",
                    DaysOffPull = 26,
                    RoleId = 4,
                }
            };
            foreach (var user in users)
            {
                user.PasswordHash = _passwordHasher.HashPassword(user, "");
            }

            for(int i = 0; i < 100; i++)
            {
                var worker = new User()
                {
                    Name = $"Name{i}",
                    Surname = $"Surname{i}",
                    Login = $"Worker{i}",
                    DaysOffPull = 26,
                    DaysOffOnDemandPull = 4,
                    RoleId = 1,
                };
                worker.PasswordHash = _passwordHasher.HashPassword(worker,$"{i}");
                users.Add(worker);
            }
            return users;
        }
    }
}
