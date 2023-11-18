using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Commands.RejectRequest
{
    public record RejectRequestCommand : IRequest<bool>, IManagerChoiceCommand
    {
       
        public RejectRequestCommand(Request request)
        {
            Request = request;
        }

        public Request Request { get; }

    }
}
