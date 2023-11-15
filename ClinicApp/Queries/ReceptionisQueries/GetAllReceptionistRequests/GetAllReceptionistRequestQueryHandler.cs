﻿using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp.Queries.ReceptionisQueries.GetAllRequests
{
    public class GetAllReceptionistRequestQueryHandler : IRequestHandler<GetAllReceptionistRequestsQuery, List<Request>>
    {
        private readonly IRequestRepository _requestRepository;
        public GetAllReceptionistRequestQueryHandler(IRequestRepository reguestRepository)
        {
            _requestRepository = reguestRepository;
        }
        public async Task<List<Request>> Handle(GetAllReceptionistRequestsQuery request, CancellationToken cancellationToken)
        {
            var requests = await _requestRepository.GetAllRequestsWithUserAndDayOffTypeByStateId(request.StateId);
            return requests.ToList();
        }
    }
}