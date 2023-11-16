using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Commands.ManagerCommands
{
    public class AcceptRequestCommandHandler : IRequestHandler<AcceptRequestCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        private readonly IRequestRepository _requestRepository;
        private readonly IDayOffRepository _dayOffRepository;
        public AcceptRequestCommandHandler(
            IUserRepository userRepository,
            IRequestRepository requestRepository,
            IDayOffRepository dayOffRepository)
        {
            _userRepository = userRepository;
            _requestRepository = requestRepository;
            _dayOffRepository = dayOffRepository;
        }

        public async Task<bool> Handle(AcceptRequestCommand request, CancellationToken cancellationToken)
        {
            List<DayOff> daysOff = new List<DayOff>();
            request.Request.RequestStateId = 4;
            var user = await _userRepository.GetUserWithSchedulesByUserId(request.Request.UserId);
            user.Schedules.OrderBy(s => s.Date);
            int dayOffCounter = 0;
            foreach(var schedule in user.Schedules)
            {
                if(schedule.Date >= request.Request.From && schedule.Date <= request.Request.To)
                {
                    var dayOff = new DayOff()
                    {
                        DayOffType = request.Request.DayOffType,
                        Date = schedule.Date,
                    };
                    daysOff.Add(dayOff);
                    schedule.IsDayOff = true;
                    dayOffCounter++;
                }
            }
            if(request.Request.DayOffTypeId == 1)
                user.DaysOffPull -= dayOffCounter;
            else if(request.Request.DayOffTypeId == 3)
                user.DaysOffOnDemandPull -= dayOffCounter;

            await _userRepository.Update(user);
            await _requestRepository.Update(request.Request);
            await _dayOffRepository.AddRange(daysOff);

            return true;
        }
    }
}
