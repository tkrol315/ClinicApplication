﻿using ClinicApp.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Commands.AcceptUserDetails
{
    public class AcceptUserDetailsCommandHandler : IRequestHandler<AcceptUserDetailsCommand, bool>
    {
        private readonly IUserRepository _userRepository;

        public AcceptUserDetailsCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> Handle(AcceptUserDetailsCommand request, CancellationToken cancellationToken)
        {
            if(request.Login == string.Empty ||
                request.Name == string.Empty ||
                request.Surname == string.Empty ||
                request.DaysOffPull == string.Empty)
            {
                throw new ArgumentException("Wszystkie pola muszą pozostać uzupełnione");
            }
            var users = await _userRepository.GetAll();
            if (users.Any(u => u.Login == request.Login && u.Id != request.User.Id))
            {
                throw new ArgumentException("Ten login jest już zajęty");
            }
            request.User.Login = request.Login;
            request.User.Name = request.Name;
            request.User.Surname = request.Surname;
            request.User.DaysOffPull = int.Parse(request.DaysOffPull);

            await _userRepository.Update(request.User);
            return true;
        }
    }
}
