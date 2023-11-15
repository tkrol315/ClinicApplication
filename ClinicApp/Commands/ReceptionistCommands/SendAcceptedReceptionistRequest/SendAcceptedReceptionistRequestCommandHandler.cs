using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;

namespace ClinicApp.Commands.ReceptionistCommands.SendAcceptedReceptionistRequest
{
    public class SendAcceptedReceptionistRequestCommandHandler : IRequestHandler<SendAcceptedReceptionistRequestCommand, bool>
    {
        private readonly IReceptionistRequestRepository _receptionistRequestRepository;
        private readonly IRequestRepository _requestRepository;
        public SendAcceptedReceptionistRequestCommandHandler(
            IReceptionistRequestRepository receptionistRequestRepository,
            IRequestRepository requestRepository)
        {
            _receptionistRequestRepository = receptionistRequestRepository;
            _requestRepository = requestRepository;
        }

        public async Task<bool> Handle(SendAcceptedReceptionistRequestCommand request, CancellationToken cancellationToken)
        {
            request.Request.RequestStateId = 3;
           
            await _requestRepository.Update(request.Request);
            var receptionistRequest = new ReceptionistRequest()
            {
                Request = request.Request,
                From = request.From,
                To = request.To,
            };
            await _receptionistRequestRepository.Add(receptionistRequest);
            return true;
        }
    }
}
