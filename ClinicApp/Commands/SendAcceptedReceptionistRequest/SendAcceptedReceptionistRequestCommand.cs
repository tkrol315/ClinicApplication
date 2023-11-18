using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Commands.SendAcceptedReceptionistRequest
{
    public record SendAcceptedReceptionistRequestCommand : IRequest<bool>
    {
        public SendAcceptedReceptionistRequestCommand(Request request, DateTime from, DateTime to)
        {
            Request = request;
            From = from;
            To = to;
        }
        public Request Request { get; }
        public DateTime From { get; }
        public DateTime To { get; }
    }
}
