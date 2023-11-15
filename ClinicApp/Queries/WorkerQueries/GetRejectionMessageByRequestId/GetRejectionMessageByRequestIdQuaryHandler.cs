using ClinicApp.Queries.WorkerQueries.GetRejectionMessage;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.WorkerQueries.GetRejectionMessageByRequestId
{
    public class GetRejectionMessageByRequestIdQuaryHandler : IRequestHandler<GetRejectionMessageByRequestIdQuary, string>
    {
        private readonly IResponseRepository _responseRepository;

        public GetRejectionMessageByRequestIdQuaryHandler(IResponseRepository responseRepository)
        {
            _responseRepository = responseRepository;
        }

        public async Task<string> Handle(GetRejectionMessageByRequestIdQuary request, CancellationToken cancellationToken)
        {
            var response = await _responseRepository.GetResponseByRequestId(request.RequestId);
            return response.Message;
        }
    }
}
