using ClinicApp.Entities;
using MediatR;

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
