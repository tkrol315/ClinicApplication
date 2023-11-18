using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Repositories
{
    public class SubstitutionRepository :
        RepositoryAsync<Substitution>, ISubstitutionRepository
    {
        public SubstitutionRepository(ClinicDbContext dbContext) : base(dbContext) { }

        public async Task<IEnumerable<Substitution>> GetSubstitutionsWithUsers()
        {
           return await _dbContext.Substitutions.Include(s => s.User).ToListAsync();

        }
    }
}
