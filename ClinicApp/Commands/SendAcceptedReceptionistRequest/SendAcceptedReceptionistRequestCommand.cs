using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Commands.SendAcceptedReceptionistRequest
{
    public record SendAcceptedReceptionistRequestCommand(Request Request, DateTime From, DateTime To) : IRequest<bool>;
    
}
