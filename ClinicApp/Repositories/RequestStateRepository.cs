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

        public RequestStateRepository(ClinicDbContext dbContext) : base(dbContext) 
        {
            
        }
    }
}
