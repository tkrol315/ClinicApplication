using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp.Queries.ReceptionisQueries.GetAllRequests
{
    public class GetAllRequestQueryHandler : IRequestHandler<GetAllRequestsQuery, List<Request>>
    {
        private readonly IRequestRepository _requestRepository;
        public GetAllRequestQueryHandler(IRequestRepository reguestRepository)
        {
            _requestRepository = reguestRepository;
        }
        public async Task<List<Request>> Handle(GetAllRequestsQuery request, CancellationToken cancellationToken)
        {
            var requests = await _requestRepository.GetAllRequestsWithUserAndDayOffType();
            return requests.ToList();
        }
    }
}
