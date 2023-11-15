using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Commands.ReceptionistCommands.SendRejectReceptionistRequest
{
    public record SendRejectReceptionistRequestCommand : IRequest<bool>
    {
        public SendRejectReceptionistRequestCommand(string message, Request request)
        {
            Message = message;
            Request = request;
        }

        public string Message { get; init; }
        public Request Request { get; init; }
    }
}
