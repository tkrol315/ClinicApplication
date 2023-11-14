
using ClinicApp.Entities;

namespace ClinicApp.Repositories.Interfaces
{
    public interface IRequestRepository : IRepositoryAsync<Request>
    {
        Task<IEnumerable<Request>> GetAllRequestsWithUserAndDayOffType();
    }
}
