using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Commands.AssignWorker
{
    public record AssignWorkerToSubstitutionCommand : IRequest<bool>
    {
        public AssignWorkerToSubstitutionCommand(int substitutionId, int workerId)
        {
            SubstitutionId = substitutionId;
            WorkerId = workerId;
        }

        public int SubstitutionId { get; }
        public int WorkerId { get; }

    }
}
