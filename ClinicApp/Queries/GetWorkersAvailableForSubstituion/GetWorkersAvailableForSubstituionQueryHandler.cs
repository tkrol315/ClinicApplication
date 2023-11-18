using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetWorkersAvailableForSubstituion
{
    public class GetWorkersAvailableForSubstituionQueryHandler : IRequestHandler<GetWorkersAvailableForSubstituionQuery, List<User>>
    {
        private readonly ISubstitutionRepository _substitutionRepository;
        private readonly IUserRepository _userRepository;
        public GetWorkersAvailableForSubstituionQueryHandler(
            ISubstitutionRepository substitutionRepository,
            IUserRepository userRepository)
        {
            _substitutionRepository = substitutionRepository;
            _userRepository = userRepository;
        }
        public async Task<List<User>> Handle(GetWorkersAvailableForSubstituionQuery request, CancellationToken cancellationToken)
        {
            var substitution = await _substitutionRepository.Get(request.SubstitutionId);
            var workers = await _userRepository.GetUsersWithSchedulesByRoleId(1);
            var availableWorkers = new List<User>();
            foreach ( var worker in workers)
            {
                if(!worker.Schedules.Any(s => s.Date == substitution.Date))
                {
                    availableWorkers.Add(worker);
                }
            }
            return availableWorkers;
        }
    }
}
