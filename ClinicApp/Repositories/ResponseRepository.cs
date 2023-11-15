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
    public class ResponseRepository : RepositoryAsync<Response>, IResponseRepository
    {
        
        public ResponseRepository(ClinicDbContext dbContext) : base(dbContext)
        {
            
        }

        public async Task<Response> GetResponseByRequestId(int id)
        {
           return await _dbContext.Responses.SingleAsync(r => r.RequestId == id);
        }
    }
}
