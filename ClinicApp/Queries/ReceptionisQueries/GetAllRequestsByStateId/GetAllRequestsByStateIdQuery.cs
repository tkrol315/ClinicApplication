
using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Queries.ReceptionisQueries.GetAllRequests
{
    public record GetAllRequestsByStateIdQuery : IRequest<List<Request>>
    {
        public GetAllRequestsByStateIdQuery(int stateId)
        {
            StateId = stateId;
        }
        public int StateId { get; init; }

    } 
}
