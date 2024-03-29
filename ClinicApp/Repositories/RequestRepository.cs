﻿using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp.Repositories
{
    public class RequestRepository : RepositoryAsync<Request>, IRequestRepository
    {
        public RequestRepository(ClinicDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Request>> GetAllRequestsForUserByUserId(int userId)
        {
           var requests = await _dbContext.Requests
                .Include(r => r.RequestState)
                .Where(r => r.UserId == userId)
                .ToListAsync();
            return requests;
        }

        public async Task<IEnumerable<Request>> GetAllRequestsWithUserAndDayOffTypeByStateId(int id)
        {
            var requests = await _dbContext.Requests
                .Include(r => r.DayOffType)
                .Include(r => r.User)
                .Where(r => r.RequestStateId == id)
                .ToListAsync();
            return requests;
        }

        public async Task<IEnumerable<Request>> GetAllRequestsWithUserAndDayOffTypeByStateIds(int[] ids)
        {
            var requests = await _dbContext.Requests
               .Include(r => r.DayOffType)
               .Include(r => r.User)
               .Where(r => ids.Contains(r.RequestStateId))
               .ToListAsync();
            return requests;
        }

        public async Task<IEnumerable<Request>> GetAllRequestsWithUserSubstitutionsAndDayOffTypeByStateId(int id)
        {
            var requests = await _dbContext.Requests
               .Include(r => r.DayOffType)
               .Include(r => r.User)
               .Include(r => r.Substitutions)
               .Where(r => r.RequestStateId == id)
               .ToListAsync();
            return requests;
        }
    }
}
