using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.WorkerQueries.GetAllWorkerRequests
{
    public class GetAllWorkerRequestsQuaryHandler : IRequestHandler<GetAllWorkerRequestsQuary, List<Request>>
    {
        private readonly IRequestRepository _requestRepository;

        public GetAllWorkerRequestsQuaryHandler(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public async Task<List<Request>> Handle(GetAllWorkerRequestsQuary request, CancellationToken cancellationToken)
        {
            var requests =  await _requestRepository.GetAllRequestsForUserByUserId(request.UserId);
            return requests.ToList();
        }
    }
}
