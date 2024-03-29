﻿using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Repositories
{
    public class DayOffTypeRepository 
        : RepositoryAsync<DayOffType>, IDayOffTypeRepository
    {

        public DayOffTypeRepository(ClinicDbContext dbContext) 
            : base(dbContext) 
        {
        }
        public async Task<List<string>> GetAllNames()
        {
            var dayOffTypes = await _dbContext.DayOffTypes
                .ToListAsync();
            List<string> names = dayOffTypes
                .Select(dayOffType => dayOffType.Name)
                .ToList();
            return names;
        }
    }
}
