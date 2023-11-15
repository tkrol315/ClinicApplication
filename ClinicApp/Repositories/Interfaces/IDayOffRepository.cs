using ClinicApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Repositories.Interfaces
{
    public interface IDayOffRepository : IRepositoryAsync<DayOff>
    {
        Task<IEnumerable<DayOff>> GetAllDaysOffByUserId(int userId);
    }
}
