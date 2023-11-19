using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetAllRequestsWithSubstitutionsByStateId
{
    public class GetAllRequestsWithSubstitutionsByStateIdQueryHandler : IRequestHandler<GetAllRequestsWithSubstitutionsByStateIdQuery,List<Request>>
    {
        private readonly IRequestRepository _requestRepository;
        public GetAllRequestsWithSubstitutionsByStateIdQueryHandler(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public async Task<List<Request>> Handle(GetAllRequestsWithSubstitutionsByStateIdQuery request, CancellationToken cancellationToken)
        {
            var requests = await _requestRepository.GetAllRequestsWithUserSubstitutionsAndDayOffTypeByStateId(request.StateId);
            return requests.ToList();
        }
    }
}
