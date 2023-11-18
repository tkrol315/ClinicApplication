using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetAllSubstitutions
{
    public record GetAllSubstitutionsWithUsersQuery : IRequest<List<Substitution>>
    {
        
    }
}
