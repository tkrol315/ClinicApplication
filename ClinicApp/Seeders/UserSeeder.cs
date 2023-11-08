using ClinicApp.Entities;
using ClinicApp.Seeders.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Name = "WorkerName",
                    Surname = "WorkerSurname",
                    Login = "Worker",
                    PasswordHash = "",
                    DaysOffPull = 26,
                    RoleId = 1,
                },
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
            return users;
        }
    }
}
