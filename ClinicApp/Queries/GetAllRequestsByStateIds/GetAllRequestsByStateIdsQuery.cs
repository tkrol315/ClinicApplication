using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetAllRequestsByStateIds
{
    public record GetAllRequestsByStateIdsQuery : IRequest<List<Request>>
    {
        public GetAllRequestsByStateIdsQuery(int[] stateIds)
        {
            StateIds = stateIds;
        }
        public int[] StateIds { get;}
    }
}
