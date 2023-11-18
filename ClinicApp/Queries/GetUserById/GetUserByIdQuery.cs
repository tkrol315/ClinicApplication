using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetUserById
{
    public record GetUserByIdQuery : IRequest<User>
    {
        public GetUserByIdQuery(int userId)
        {
            UserId = userId;    
        }
        public int UserId { get; }
    }
}
