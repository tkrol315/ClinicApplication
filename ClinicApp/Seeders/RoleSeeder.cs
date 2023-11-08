using ClinicApp.Entities;
using ClinicApp.Enums;
using ClinicApp.Seeders.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Seeders
{
    public class RoleSeeder : ISeeder
    {
        private readonly ClinicDbContext _dbContext;

        public RoleSeeder(ClinicDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Seed()
        {
            if (!_dbContext.Roles.Any())
            {
                var roles = GetRoles();
                _dbContext.Roles.AddRange(roles);
                await _dbContext.SaveChangesAsync();
            }
        }

        private IEnumerable<Role> GetRoles()
        {
            var roles = new List<Role>()
            {
                new Role()
                {
                    Name = "Worker",
                    StartForm = StartForm.BasicWorkerApplicationForm
                },
                new Role()
                {
                    Name = "Receptionist",
                      StartForm = StartForm.ReceptionistApplicationForm
                },
                new Role()
                {
                    Name = "Manager",
                     StartForm = StartForm.ManagerMainForm
                },
                new Role()
                {
                    Name = "Admin",
                     StartForm = StartForm.MainAdministratorForm
                }
            };
            return roles;
        }
    }
}
