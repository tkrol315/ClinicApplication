using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetRejectionMessageByRequestId
{
    public record GetRejectionMessageByRequestIdQuery : IRequest<string>
    {
        public GetRejectionMessageByRequestIdQuery(int requestId)
        {
            RequestId = requestId;
        }
        public int RequestId { get;}
    }
}
