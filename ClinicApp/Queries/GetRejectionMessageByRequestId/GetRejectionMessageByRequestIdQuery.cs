﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetRejectionMessageByRequestId
{
    public record GetRejectionMessageByRequestIdQuery(int RequestId) : IRequest<string>;
  
}
