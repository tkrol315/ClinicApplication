﻿using ClinicApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Repositories.Interfaces
{
    public interface IDayOffTypeRepository : IRepositoryAsync<DayOffType>
    {
        Task<List<string>> GetAllNames();
    }
}
