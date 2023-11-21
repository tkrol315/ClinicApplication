using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Commands.AssignWorker
{
    public record AssignWorkerToSubstitutionCommand(int SubstitutionId, int WorkerId) : IRequest<bool>;
   
}
