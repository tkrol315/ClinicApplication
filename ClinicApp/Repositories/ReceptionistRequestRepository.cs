using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Repositories
{
    public class ReceptionistRequestRepository : RepositoryAsync<ReceptionistRequest> ,IReceptionistRequestRepository
    {
        public ReceptionistRequestRepository(ClinicDbContext dbContext) : base(dbContext)
        { 
        }
       
    }
}
