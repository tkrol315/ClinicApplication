using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Commands.LoginUser
{
    public record LoginUserCommand : IRequest<User>
    {
        public LoginUserCommand(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public string Login { get; }
        public string Password { get; }

    }

}
