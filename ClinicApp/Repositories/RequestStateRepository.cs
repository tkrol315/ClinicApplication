using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Repositories
{
    public class RequestStateRepository : RepositoryAsync<RequestState>, IRequestStateRepository
    {
        private readonly ClinicDbContext _dbContext;

        public RequestStateRepository(ClinicDbContext dbContext) : base(dbContext) 
        {
            _dbContext = dbContext;
        }
    }
}
