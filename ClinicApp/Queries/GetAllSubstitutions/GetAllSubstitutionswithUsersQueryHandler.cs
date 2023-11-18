using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetAllSubstitutions
{
    public class GetAllSubstitutionswithUsersQueryHandler : IRequestHandler<GetAllSubstitutionsWithUsersQuery, List<Substitution>>
    {
        private readonly ISubstitutionRepository _substitutionRepository;

        public GetAllSubstitutionswithUsersQueryHandler(ISubstitutionRepository substitutionRepository)
        {
            _substitutionRepository = substitutionRepository;
        }
        public async Task<List<Substitution>> Handle(GetAllSubstitutionsWithUsersQuery request, CancellationToken cancellationToken)
        {
            var substitutions = await _substitutionRepository.GetSubstitutionsWithUsers();
            return substitutions.ToList();
        }
    }
}
