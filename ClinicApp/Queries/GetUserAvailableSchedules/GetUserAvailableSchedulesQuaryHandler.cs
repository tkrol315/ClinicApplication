using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetUserAvailableSchedules
{
    public class GetUserAvailableSchedulesQuaryHandler : IRequestHandler<GetUserAvailableSchedulesQuary, List<Schedule>>
    {
        private readonly IScheduleRepository _scheduleRepository;
        private readonly IUserRepository _userRepository;
        public GetUserAvailableSchedulesQuaryHandler(
            IScheduleRepository scheduleRepository,
            IUserRepository userRepository)
        {
            _scheduleRepository = scheduleRepository;
            _userRepository = userRepository;
        }
        public async Task<List<Schedule>> Handle(GetUserAvailableSchedulesQuary request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserWithSchedulesAndRequestsByUserId(request.UserId);

            var schedules = user.Schedules.Where(s => !user.Requests
              .Any(r => r.From.Date <= s.Date.Date && r.To >= s.Date.Date)).OrderBy(s => s.Date);

            return schedules.ToList();


        }
    }
}
