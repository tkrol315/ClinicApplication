using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.ReceptionisQueries.GetUserDaysOff
{
    public class GetUserDaysOffQuaryHandler : IRequestHandler<GetUserDaysOffQuary, List<DayOff>>
    {
        private readonly IDayOffRepository _dayOffRepository;

        public GetUserDaysOffQuaryHandler(IDayOffRepository dayOffRepository)
        {
            _dayOffRepository = dayOffRepository;
        }

        public async Task<List<DayOff>> Handle(GetUserDaysOffQuary request, CancellationToken cancellationToken)
        {
           var daysOff = await _dayOffRepository.GetAllDaysOffByUserId(request.UserId);
            return daysOff.ToList();
        }
    }
}
