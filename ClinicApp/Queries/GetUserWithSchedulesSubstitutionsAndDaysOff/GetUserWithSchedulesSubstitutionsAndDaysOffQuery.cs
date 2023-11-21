using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Queries.GetUserSubstitutions
{
    public record GetUserWithSchedulesSubstitutionsAndDaysOffQuery(int UserId) : IRequest<User>;
    
}
