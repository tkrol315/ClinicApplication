
using ClinicApp.Entities;

namespace ClinicApp.Repositories.Interfaces
{
    public interface IRequestRepository : IRepositoryAsync<Request>
    {
        Task<IEnumerable<Request>> GetAllRequestsWithUserAndDayOffTypeByStateId(int id);
        Task<IEnumerable<Request>> GetAllRequestsForUserByUserId(int id);
        Task<IEnumerable<Request>> GetAllRequestsWithUserSubstitutionsAndDayOffTypeByStateId(int id);
        Task<IEnumerable<Request>> GetAllRequestsWithUserAndDayOffTypeByStateIds(int[] ids);
    }
}
