
using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Queries.ReceptionisQueries.GetAllRequests
{
    public record GetAllReceptionistRequestsQuery : IRequest<List<Request>>
    {
        public GetAllReceptionistRequestsQuery(int stateId)
        {
            StateId = stateId;
        }
        public int StateId { get; init; }

    } 
}
