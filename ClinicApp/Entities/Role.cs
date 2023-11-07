using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Entities
{
    internal class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        virtual public List<User> Users { get; set; }
    }
}
