using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp.Queries.GetAllRequestsByStateId
{
    public class GetAllRequestsByStateIdQueryHandler : IRequestHandler<GetAllRequestsByStateIdQuery, List<Request>>
    {
        private readonly IRequestRepository _requestRepository;
        public GetAllRequestsByStateIdQueryHandler(IRequestRepository reguestRepository)
        {
            _requestRepository = reguestRepository;
        }
        public async Task<List<Request>> Handle(GetAllRequestsByStateIdQuery request, CancellationToken cancellationToken)
        {
            var requests = await _requestRepository.GetAllRequestsWithUserAndDayOffTypeByStateId(request.StateId);
            return requests.ToList();
        }
    }
}
