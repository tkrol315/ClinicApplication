using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetWorkersAvailableForSubstituion
{
    public record GetWorkersAvailableForSubstituionQuery : IRequest<List<User>>
    {
        public GetWorkersAvailableForSubstituionQuery(int substitutionId)
        {
            SubstitutionId = substitutionId;
        }
        public int SubstitutionId { get;}
    }
}
