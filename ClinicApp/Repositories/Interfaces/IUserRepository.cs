using ClinicApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Repositories.Interfaces
{
    public interface IUserRepository : IRepositoryAsync<User>
    {
        Task<User> GetUserByLoginWithRole(string login);
        Task<User> GetUserWithSchedulesByUserId(int id);
    }
}
