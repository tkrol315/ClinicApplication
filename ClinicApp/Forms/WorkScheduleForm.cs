using ClinicApp.Entities;
using ClinicApp.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp.Forms
{
    public partial class WorkScheduleForm : Form
    {
        public List<Schedule> UserSchedules { get; set; }
        public List<DayOff> DaysOff { get; set; }
        public WorkScheduleForm()
        {
            InitializeComponent();
          
        }

        public void FillDGV()
        {
            
            //create schedule if day off validation
            foreach (var schedule in UserSchedules) 
            {
                object[] data = {
                        schedule.Date.ToString("dd-MM-yyyy"),
                        schedule.TimeOfDay == TimeOfDay.Morning ? "Poranna" : "Popołudniowa",
                        "NIE"
                    };
                WorkSchedule_DGV.Rows.Add(data);
            }
        }
    }
}
