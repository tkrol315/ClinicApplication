using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;

namespace ClinicApp.Commands.ReceptionistCommands.SendAcceptedReceptionistRequest
{
    public class SendAcceptedReceptionistRequestCommandHandler : IRequestHandler<SendAcceptedReceptionistRequestCommand, bool>
    {
        private readonly IRequestRepository _requestRepository;
        public SendAcceptedReceptionistRequestCommandHandler(
            IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        public async Task<bool> Handle(SendAcceptedReceptionistRequestCommand request, CancellationToken cancellationToken)
        {
            request.Request.RequestStateId = 3;
            request.Request.From = request.From;
            request.Request.To = request.To;
           
            await _requestRepository.Update(request.Request);
            return true;
        }
    }
}
