using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Entities
{
    public class Request
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Message { get; set; }
        public int DayOffTypeId { get; set; }
        public DayOffType DayOffType { get; set; }
    }
}
