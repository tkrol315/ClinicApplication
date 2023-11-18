using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetUserSubstitutions
{
    public record GetUserWithSchedulesSubstitutionsAndDaysOffQuery : IRequest<User>
    {
        public GetUserWithSchedulesSubstitutionsAndDaysOffQuery(int userId)
        {
            UserId = userId;
        }
        public int UserId { get; set; }

       
    }
}
