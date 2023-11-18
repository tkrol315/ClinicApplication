using ClinicApp.Entities;
using ClinicApp.Enums;

namespace ClinicApp.Forms
{
    public partial class WorkScheduleForm : Form
    {
        public User User { get; set; }

        public WorkScheduleForm()
        {
            InitializeComponent();
          
        }
     
        public void FillDGV()
        {
            int counter = 0;
            object[] data;
            User.Schedules = User.Schedules.OrderBy(s => s.Date).ToList();
            bool isDayOff = false;
            bool isSubstitution = false;

            for (DateTime i = User.Schedules[0].Date; i <= User.Schedules[User.Schedules.Count - 1].Date; i = i.AddDays(1))
            {
                isDayOff = User.DaysOff.Any(d => d.Date.Date == User.Schedules[counter].Date.Date);

                if (i.Date == User.Schedules[counter].Date)
                {
                    data = new object[]
                    {
                       User.Schedules[counter].Date.ToString("dd-MM-yyyy"),
                        User.Schedules[counter].TimeOfDay == TimeOfDay.Morning ? "Poranna" : "Popołudniowa",
                        isDayOff ? "TAK" : "NIE"
                    };
                    counter++;
                }
                else
                {
                    isSubstitution = User.Substitutions.Any(s => s.Date == i.Date);
                    isDayOff = false;
                    data = new object[]
                    {
                        i.ToString("dd-MM-yyyy"),
                        isSubstitution ? "Zastępstwo" : "Wolne",
                        "NIE"
                    };
                }
                var index = WorkSchedule_DGV.Rows.Add(data);
                if(isDayOff)
                {
                    WorkSchedule_DGV.Rows[index].DefaultCellStyle.BackColor = Color.SpringGreen;
                }
                else if (isSubstitution)
                {
                    WorkSchedule_DGV.Rows[index].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                }
            }
        }
    }
}
