using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.ReceptionisQueries.GetUserSchedules
{
    public record GetUserSchedulesQuary : IRequest<List<Schedule>>
    {
        public GetUserSchedulesQuary(int userId)
        {
            UserId = userId;
        }
        public int UserId { get; init; }
    }
}
