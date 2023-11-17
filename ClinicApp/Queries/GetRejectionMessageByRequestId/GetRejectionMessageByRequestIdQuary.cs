using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetRejectionMessageByRequestId
{
    public record GetRejectionMessageByRequestIdQuary : IRequest<string>
    {
        public GetRejectionMessageByRequestIdQuary(int requestId)
        {
            RequestId = requestId;
        }
        public int RequestId { get; init; }
    }
}
