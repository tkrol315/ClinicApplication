using Bogus;
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
                    Name = "Receptionist",
                    Surname = "Receptionist",
                    Login = "receptionist",
                    PasswordHash = "receptionist",
                    DaysOffPull = 26,
                    RoleId = 2,
                },
                 new User()
                {
                    Name = "Manager",
                    Surname = "Manager",
                    Login = "manager",
                    PasswordHash = "manager",
                    DaysOffPull = 26,
                    RoleId = 3,
                },
                   new User()
                {
                    Name = "Admin",
                    Surname = "Admin",
                    Login = "admin",
                    PasswordHash = "admin",
                    DaysOffPull = 26,
                    RoleId = 4,
                }
            };
            foreach (var user in users)
            {
                user.PasswordHash = _passwordHasher.HashPassword(user, user.PasswordHash);
            }
            var workerGenerator = new Faker<User>()
                .RuleFor(w => w.Name, f => f.Name.FirstName())
                .RuleFor(w => w.Surname, f => f.Name.LastName())
                .RuleFor(w => w.Login, f => f.Person.UserName);

            for(int i = 0; i < 100; i++)
            {
                var worker = workerGenerator.Generate();
                worker.DaysOffPull = 26;
                worker.DaysOffOnDemandPull = 4;
                worker.RoleId = 1;
                worker.PasswordHash = _passwordHasher.HashPassword(worker, "worker");
               
                users.Add(worker);
            }
            return users;
        }
    }
}
