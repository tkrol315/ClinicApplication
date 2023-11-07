﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Entities
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public int DaysOffPull { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public virtual  List<Schedule> Schedules{ get; set; }
        public virtual List<DayOff> DaysOff { get; set; }
        public virtual List<Request> Requests { get; set; }
        public virtual List<Response> Responses{ get; set; }
    }
}