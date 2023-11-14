
using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Queries.ReceptionisQueries.GetAllRequests
{
    public record GetAllRequestsQuery(): IRequest<List<Request>>;
}
