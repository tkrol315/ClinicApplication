using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetAllUsers
{
    public class GetAllUsersWithRolesQueryHandler : IRequestHandler<GetAllUsersWithRolesQuery, List<User>>
    {
        private readonly IUserRepository _userRepository;

        public GetAllUsersWithRolesQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<List<User>> Handle(GetAllUsersWithRolesQuery request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllUsersWithRoles();
            return users.ToList();
        }
    }
}
