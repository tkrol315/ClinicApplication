using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Commands.ReceptionistCommands.SendAcceptedReceptionistRequest
{
    public record SendAcceptedReceptionistRequestCommand : IRequest<bool>
    {
        public SendAcceptedReceptionistRequestCommand(Request request, DateTime from, DateTime to)
        {
            Request = request;
            From = from;
            To = to;
        }
        public Request Request { get; init; }
        public DateTime From { get; init; }
        public DateTime To { get; init; }
    }
}
