using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Queries.GetAllRequestsByStateId
{
    public record GetAllRequestsByStateIdQuery(int StateId) : IRequest<List<Request>>;
  
}
