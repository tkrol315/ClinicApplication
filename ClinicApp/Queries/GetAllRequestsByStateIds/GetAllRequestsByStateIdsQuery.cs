using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetAllRequestsByStateIds
{
    public record GetAllRequestsByStateIdsQuery(int[] StateIds) : IRequest<List<Request>>;
    
}
