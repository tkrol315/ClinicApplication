﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Entities
{
    public class RequestState
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public virtual List<Request> Requests { get; set; }
    }
}
