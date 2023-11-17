using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetUserSchedules
{
    public class GetUserSchedulesQuaryHandler : IRequestHandler<GetUserSchedulesQuary, List<Schedule>>
    {
        private readonly IScheduleRepository _scheduleRepository;

        public GetUserSchedulesQuaryHandler(IScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public async Task<List<Schedule>> Handle(GetUserSchedulesQuary request, CancellationToken cancellationToken)
        {
           var schedules = await _scheduleRepository.GetSchedulesByUserId(request.UserId);
            return schedules.ToList();
        }
    }
}
