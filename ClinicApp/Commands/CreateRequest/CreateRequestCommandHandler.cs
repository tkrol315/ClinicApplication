using ClinicApp.Dtos;
using ClinicApp.Entities;
using ClinicApp.Repositories;
using ClinicApp.Repositories.Interfaces;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Commands.CreateRequest
{
    public class CreateRequestCommandHandler : IRequestHandler<CreateRequestCommand, Request>
    {
        private readonly IRequestRepository _requestRepository;
        private readonly IDayOffTypeRepository _dayOffTypeRepository;
        private readonly IRequestStateRepository _requestStateRepository;
        private readonly IValidator<CreateRequestCommand> _createValidator;

        public CreateRequestCommandHandler(
            IRequestRepository requestRepository,
            IDayOffTypeRepository dayOffTypeRepository,
            IRequestStateRepository requestStateRepository,
            IValidator<CreateRequestCommand> createValidator)
        {
            _requestRepository = requestRepository;
            _dayOffTypeRepository = dayOffTypeRepository;
            _requestStateRepository = requestStateRepository;
            _createValidator = createValidator;
        }
        public async Task<Request> Handle(
            CreateRequestCommand request, CancellationToken cancellationToken)
        {
            var result = _createValidator.Validate(request);
            if (!result.IsValid)
            {
                throw new InvalidDataException("NOT VALID");
            }
            var dayOffTypes = await _dayOffTypeRepository.GetAll();
            var dayOffType = dayOffTypes.FirstOrDefault(t => t.Name == request.DayOffTypeName);
            if (dayOffType is null) throw new InvalidDataException("Wrong day off typeS");

            var requestState = await _requestStateRepository.Get(1);
            var newRequest = new Request()
            {
                UserId = UserSession.CurrentUser.Id,
                Message = request.RequestContent,
                DayOffTypeId = dayOffType.Id,
                RequestState = requestState
            };
            await _requestRepository.Add(newRequest);
            return newRequest;
        }
    }
}
