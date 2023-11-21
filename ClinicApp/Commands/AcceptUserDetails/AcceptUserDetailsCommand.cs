using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Commands.AcceptUserDetails
{
    public record AcceptUserDetailsCommand(User User, string Login, string Name, string Surname, string DaysOffPull) : IRequest<bool>;
    
}
