using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Queries.GetAllWorkerRequests
{
    public record GetAllWorkerRequestsQuary : IRequest<List<Request>>
    {
        public GetAllWorkerRequestsQuary(int userId)
        {
            UserId = userId;
        }
        public int UserId { get; init; }
    }
}
