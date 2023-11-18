using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetRejectionMessageByRequestId
{
    public class GetRejectionMessageByRequestIdQueryHandler : IRequestHandler<GetRejectionMessageByRequestIdQuery, string>
    {
        private readonly IResponseRepository _responseRepository;

        public GetRejectionMessageByRequestIdQueryHandler(IResponseRepository responseRepository)
        {
            _responseRepository = responseRepository;
        }

        public async Task<string> Handle(GetRejectionMessageByRequestIdQuery request, CancellationToken cancellationToken)
        {
            var response = await _responseRepository.GetResponseByRequestId(request.RequestId);
            return response.Message;
        }
    }
}
