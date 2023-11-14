using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp.Repositories
{
    public class RequestRepository : RepositoryAsync<Request>, IRequestRepository
    {
        private readonly ClinicDbContext _dbContext;
        public RequestRepository(ClinicDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Request>> GetAllRequestsWithUserAndDayOffType()
        {
            var requests = await _dbContext.Requests.Include(r => r.DayOffType).Include(r => r.User).ToListAsync();
            return requests;
        }
    
    }
}
