using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Commands.CreateRequest
{
    public record CreateRequestCommand : IRequest<Request>
    {
        public CreateRequestCommand(
            string requestContent,
            string dayOffTypeName,
            int userId
            )
        {
            RequestContent = requestContent;
            DayOffTypeName = dayOffTypeName;
            UserId = userId;
        }
        public string RequestContent { get; }
        public string DayOffTypeName { get; }
        public int UserId { get; }

    }
}
