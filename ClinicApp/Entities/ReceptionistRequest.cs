using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Entities
{
    public class ReceptionistRequest
    {
        public int Id { get; set; }
        public Request Request { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
