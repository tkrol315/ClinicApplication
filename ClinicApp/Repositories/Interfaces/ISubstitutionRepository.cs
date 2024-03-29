﻿using ClinicApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Repositories.Interfaces
{
    public interface ISubstitutionRepository : IRepositoryAsync<Substitution>
    {
        Task<IEnumerable<Substitution>> GetSubstitutionsWithUsers();
    }
}
