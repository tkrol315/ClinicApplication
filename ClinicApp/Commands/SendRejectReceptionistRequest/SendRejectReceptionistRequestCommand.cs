using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Commands.SendRejectReceptionistRequest
{
    public record SendRejectReceptionistRequestCommand(string Message, Request Request) : IRequest<bool>;
  
}
