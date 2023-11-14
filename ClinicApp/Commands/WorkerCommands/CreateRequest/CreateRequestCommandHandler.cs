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

namespace ClinicApp.Commands.WorkerCommands.CreateRequest
{
    public class CreateRequestCommandHandler : IRequestHandler<CreateRequestCommand, bool>
    {
        private readonly IRequestRepository _requestRepository;
        private readonly IDayOffTypeRepository _dayOffTypeRepository;
        private readonly IValidator<CreateRequestCommand> _createValidator;

        public CreateRequestCommandHandler(
            IRequestRepository requestRepository,
            IDayOffTypeRepository dayOffTypeRepository,
            IValidator<CreateRequestCommand> createValidator)
        {
            _requestRepository = requestRepository;
            _dayOffTypeRepository = dayOffTypeRepository;
            _createValidator = createValidator;
        }
        public async Task<bool> Handle(
            CreateRequestCommand request, CancellationToken cancellationToken)
        {
            var result = _createValidator.Validate(request);
            if (!result.IsValid)
            {
                throw new InvalidDataException("NOT VALID");
            }
            var dayOffTypes = await _dayOffTypeRepository.GetAll();
            var dayOffType = dayOffTypes.FirstOrDefault(t => t.Name == request.DayOffTypeName);
            if (dayOffType is null) return false;

            var newRequest = new Request()
            {
                UserId = UserSession.CurrentUser.Id,
                Message = request.RequestContent,
                DayOffTypeId = dayOffType.Id,
            };
            await _requestRepository.Add(newRequest);
            return true;
        }
    }
}
