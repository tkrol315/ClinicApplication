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

        public async Task<User> GetUserByLoginWithRole(string login)
        {
            var user = await _dbContext.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Login == login);
            return user;
        }


    }
}
