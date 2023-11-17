using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Commands.RejectRequest
{
    public class RejectRequestCommandHandler : IRequestHandler<RejectRequestCommand, bool>
    {
        private readonly IRequestRepository _requestRepository;
        public RejectRequestCommandHandler(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }
        public async Task<bool> Handle(RejectRequestCommand request, CancellationToken cancellationToken)
        {
            request.Request.RequestStateId = 2;
            await _requestRepository.Update(request.Request);
            return true;
        }
    }
}
