using ClinicApp.Entities;
using ClinicApp.Enums;

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
            int counter = 0;
            object[] data;
           
            for(DateTime i = UserSchedules[0].Date; i <= UserSchedules.Last().Date; i = i.AddDays(1))
            {
                if (i.Date == UserSchedules[counter].Date)
                {
                    var isDayOff = DaysOff.Any(d => d.Date.Date == UserSchedules[counter].Date.Date);
                    data = new object[]
                    {
                        UserSchedules[counter].Date.ToString("dd-MM-yyyy"),
                        UserSchedules[counter].TimeOfDay == TimeOfDay.Morning ? "Poranna" : "Popołudniowa",
                        isDayOff ? "TAK" : "NIE"
                    };
                    counter++;
                }
                else
                {
                    data = new object[]
                    {
                        i.ToString("dd-MM-yyyy"),
                        "Wolne",
                        "NIE"
                    };
                }
                WorkSchedule_DGV.Rows.Add(data);
            }
        }
    }
}
