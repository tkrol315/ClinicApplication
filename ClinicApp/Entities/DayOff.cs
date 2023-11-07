using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Entities
{
    public class DayOff
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int DayOffTypeId { get; set; }
        public DayOffType DayOffType { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
