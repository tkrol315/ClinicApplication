using ClinicApp.Entities;

namespace ClinicApp.Repositories.Interfaces
{
    public interface IResponseRepository : IRepositoryAsync<Response>
    {
        Task<Response> GetResponseByRequestId(int id);
    }
}
