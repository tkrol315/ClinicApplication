using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;

namespace ClinicApp.Commands.SendRejectReceptionistRequest
{
    public class SendRejectReceptionistRequestCommandHandler : IRequestHandler<SendRejectReceptionistRequestCommand, bool>
    {
        private readonly IResponseRepository _responseRepository;
        public SendRejectReceptionistRequestCommandHandler(IResponseRepository responseRepository)
        {
            _responseRepository = responseRepository;
        }
        public async Task<bool> Handle(SendRejectReceptionistRequestCommand request, CancellationToken cancellationToken)
        {
            request.Request.RequestStateId = 2;
            var response = new Response()
            {
                Message = request.Message,
                Request = request.Request
            };
            await _responseRepository.Add(response);
            return true;
        }
    }
}
