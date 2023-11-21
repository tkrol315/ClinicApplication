using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Queries.GetAllWorkerRequests
{
    public record GetAllWorkerRequestsQuery(int UserId) : IRequest<List<Request>>;
  
}
