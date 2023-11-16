﻿using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Commands.ManagerCommands
{
    public record AcceptRequestCommand : IRequest<bool>
    {
        public AcceptRequestCommand(Request request)
        {
            Request = request;
        }

        public Request Request { get; init; }
    }
}
