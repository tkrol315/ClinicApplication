using ClinicApp.Entities;

namespace ClinicApp.Repositories.Interfaces
{
    public interface IUserRepository : IRepositoryAsync<User>
    {
        Task<User> GetUserByLoginWithRole(string login);
        Task<User> GetUserWithSchedulesAndRequestsByUserId(int id);
        Task<User> GetUserWithSchedulesAndDaysOffByUserId(int id);
        Task<IEnumerable<User>> GetUsersWithSchedulesByRoleId(int roleId);
        Task<User> GetUserWithSchedulesSubstitutionsAndDaysOffById(int id);
    }
}
