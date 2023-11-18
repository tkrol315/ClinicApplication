using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Commands.AcceptUserDetails
{
    public record AcceptUserDetailsCommand : IRequest<bool>
    {
        public AcceptUserDetailsCommand(User user, string login, string name,string surname, int daysOffPull)
        {
            User = user;  
            Login = login;
            Name = name;
            Surname = surname;
            DaysOffPull = daysOffPull;
        }

        public User User { get; }
        public string Login { get; }
        public string Name{ get; }
        public string Surname { get; }
        public int DaysOffPull{ get; }

    }
}
