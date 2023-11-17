using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetUserAvailableSchedules
{
    public record GetUserAvailableSchedulesQuary : IRequest<List<Schedule>>
    {
        public GetUserAvailableSchedulesQuary(int userId)
        {
            UserId = userId;
        }
        public int UserId { get; init; }
    }
}
