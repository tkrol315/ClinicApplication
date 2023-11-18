using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Repositories
{
    public class UserRepository
        : RepositoryAsync<User>, IUserRepository
    {

        public UserRepository(ClinicDbContext dbContext)
            : base(dbContext)
        {

        }

        public async Task<IEnumerable<User>> GetUsersWithSchedulesByRoleId(int roleId)
        {
            return await _dbContext.Users
                .Include(u => u.Schedules)
                .Where(u => u.RoleId == roleId)
                .ToListAsync();
        }

        public async Task<User> GetUserByLoginWithRole(string login)
        {
            var user = await _dbContext.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Login == login);
            return user;
        }

      

        public async Task<User> GetUserWithSchedulesAndDaysOffByUserId(int id)
        {
            var user = await _dbContext.Users
                .Include(u => u.Schedules)
                .Include(u => u.DaysOff)
                .FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<User> GetUserWithSchedulesAndRequestsByUserId(int id)
        {
            var user = await _dbContext.Users
                 .Include(u => u.Schedules)
                 .Include(u => u.Requests)
                 .FirstOrDefaultAsync(u => u.Id == id);
            return user;
        }

        public async Task<User> GetUserWithSchedulesSubstitutionsAndDaysOffById(int id)
        {
           return await _dbContext.Users
                .Include(u => u.Schedules)
                .Include(u => u.Substitutions)
                .Include(u => u.DaysOff)
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<IEnumerable<User>> GetAllUsersWithRoles()
        {
            return await _dbContext.Users.Include(u => u.Role).ToListAsync();
        }
    }
}
