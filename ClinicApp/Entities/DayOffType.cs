using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Entities
{
    public class DayOffType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<DayOff> DaysOff { get; set; }
        public virtual List<Request> Requests { get; set; }
        public virtual List<Response> Responses { get; set; }
    }
}
