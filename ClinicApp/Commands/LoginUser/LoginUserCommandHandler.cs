using ClinicApp.Dtos;
using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Commands.LoginUser
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, User>
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher<User> _passwordHasher;
        public LoginUserCommandHandler(
            IUserRepository userRepository,
            IPasswordHasher<User> passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }
        public async Task<User> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository
                .GetUserByLoginWithRole(request.Login);
            if (user is null) throw new Exception("User not found");
            var result = _passwordHasher
                .VerifyHashedPassword(user, user.PasswordHash, request.Password);
            return result == PasswordVerificationResult.Success ? user : throw new Exception("Password not match");
        }
    }
}
