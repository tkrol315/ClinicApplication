using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Commands.CreateRequest
{
    public record CreateRequestCommand(string RequestContent, string DayOffTypeName, int UserId) : IRequest<Request>;
    
}
