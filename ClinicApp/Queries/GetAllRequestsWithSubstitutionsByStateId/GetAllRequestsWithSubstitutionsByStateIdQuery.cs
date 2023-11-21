﻿using ClinicApp.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Queries.GetAllRequestsWithSubstitutionsByStateId
{
    public record GetAllRequestsWithSubstitutionsByStateIdQuery(int StateId) : IRequest<List<Request>>;
  
}
