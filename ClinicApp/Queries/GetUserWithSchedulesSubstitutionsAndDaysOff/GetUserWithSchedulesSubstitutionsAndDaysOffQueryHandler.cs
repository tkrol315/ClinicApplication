using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetUserSubstitutions
{
    public class GetUserWithSchedulesSubstitutionsAndDaysOffQueryHandler : IRequestHandler<GetUserWithSchedulesSubstitutionsAndDaysOffQuery, User>
    {
        private readonly IUserRepository _userRepository;

        public GetUserWithSchedulesSubstitutionsAndDaysOffQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> Handle(GetUserWithSchedulesSubstitutionsAndDaysOffQuery request, CancellationToken cancellationToken)
        {
            return _userRepository.GetUserWithSchedulesSubstitutionsAndDaysOffById(request.UserId);
        }
    }
}
