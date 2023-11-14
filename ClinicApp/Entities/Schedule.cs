﻿using ClinicApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Entities
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeOfDay TimeOfDay { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
