using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Commands.AssignWorker
{
    public class AssignWorkerToSubstitutionCommandHandler : IRequestHandler<AssignWorkerToSubstitutionCommand, bool>
    {
        private readonly ISubstitutionRepository _substitutionRepository;

        public AssignWorkerToSubstitutionCommandHandler(ISubstitutionRepository substitutionRepository)
        {
            _substitutionRepository = substitutionRepository;
        }

        public async Task<bool> Handle(AssignWorkerToSubstitutionCommand request, CancellationToken cancellationToken)
        {
            var substitution = await _substitutionRepository.Get(request.SubstitutionId);
            substitution.UserId = request.WorkerId;
            await _substitutionRepository.Update(substitution);
            return true;
        }
    }
}
