using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetUserDaysOff
{
    public record GetUserDaysOffQuary : IRequest<List<DayOff>>
    {
        public int UserId { get; init; }

        public GetUserDaysOffQuary(int userId)
        {
            UserId = userId;
        }
    }
}
