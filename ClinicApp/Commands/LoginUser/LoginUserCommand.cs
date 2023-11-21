using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Commands.LoginUser
{
    public record LoginUserCommand(string Login, string Password) : IRequest<User>;
   

}
