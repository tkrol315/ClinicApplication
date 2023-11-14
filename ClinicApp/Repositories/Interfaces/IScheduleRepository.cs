using ClinicApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Repositories.Interfaces
{
    public interface IScheduleRepository : IRepositoryAsync<Schedule>
    {
        Task<IEnumerable<Schedule>>GetSchedulesByUserId(int id);
    }
}
