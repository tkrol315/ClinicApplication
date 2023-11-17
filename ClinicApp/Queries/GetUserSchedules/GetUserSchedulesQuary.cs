using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetUserSchedules
{
    public record GetUserSchedulesQuary : IRequest<List<Schedule>>
    {
        public int UserId { get; set; }

        public GetUserSchedulesQuary(int userId)
        {
            UserId = userId;
        }
    }
}
