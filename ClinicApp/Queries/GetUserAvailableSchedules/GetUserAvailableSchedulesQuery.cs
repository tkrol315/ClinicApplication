using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetUserAvailableSchedules
{
    public record GetUserAvailableSchedulesQuery : IRequest<List<Schedule>>
    {
        public GetUserAvailableSchedulesQuery(int userId)
        {
            UserId = userId;
        }
        public int UserId { get;}
    }
}
