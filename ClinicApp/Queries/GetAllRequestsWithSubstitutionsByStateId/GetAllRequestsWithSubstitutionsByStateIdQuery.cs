using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetAllRequestsWithSubstitutionsByStateId
{
    public record GetAllRequestsWithSubstitutionsByStateIdQuery : IRequest<List<Request>>
    {
        public GetAllRequestsWithSubstitutionsByStateIdQuery(int stateId)
        {
            StateId = stateId;
        }
        public int StateId { get; }

    }
}
