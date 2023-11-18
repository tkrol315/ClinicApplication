using ClinicApp.Entities;
using ClinicApp.Queries.GetAllRequestsByStateId;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetAllRequestsByStateIds
{
    public class GetAllRequestsByStateIdsQueryHandler : IRequestHandler<GetAllRequestsByStateIdsQuery, List<Request>>
    {
        private readonly IRequestRepository _requestRepository;
        public GetAllRequestsByStateIdsQueryHandler(IRequestRepository reguestRepository)
        {
            _requestRepository = reguestRepository;
        }
        public async Task<List<Request>> Handle(GetAllRequestsByStateIdsQuery request, CancellationToken cancellationToken)
        {
            var requests = await _requestRepository.GetAllRequestsWithUserAndDayOffTypeByStateIds(request.StateIds);
            return requests.ToList();
        }
    }
}
