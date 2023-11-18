using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Queries.GetAllWorkerRequests
{
    public record GetAllWorkerRequestsQuery : IRequest<List<Request>>
    {
        public GetAllWorkerRequestsQuery(int userId)
        {
            UserId = userId;
        }
        public int UserId { get;}
    }
}
