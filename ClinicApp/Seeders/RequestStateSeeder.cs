using ClinicApp.Entities;
using ClinicApp.Seeders.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Seeders
{
    public class RequestStateSeeder : ISeeder
    {
        private readonly ClinicDbContext _dbContext;

        public RequestStateSeeder(ClinicDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if(!_dbContext.RequestStates.Any())
            {
                var requestStates = GetRequestStates();
                await _dbContext.RequestStates.AddRangeAsync(requestStates);
                await _dbContext.SaveChangesAsync();
            }
        }

        private IEnumerable<RequestState> GetRequestStates()
        {
            var requestStates = new List<RequestState>()
            {
                new RequestState
                {
                    Message = "Oczekujący"
                },
                new RequestState
                {
                    Message = "Odrzucony"
                },
                new RequestState
                {
                    Message = "Zaakceptowany przez recepcjonistkę"
                },
                new RequestState
                {
                    Message = "Zaakceptowany"
                }
            };
            return requestStates;
        }
    }
}
