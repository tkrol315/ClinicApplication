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
                var currentSchedule = User.Schedules[counter];
                if (i.Date == currentSchedule.Date)
                {
                    isDayOff = User.DaysOff.Any(d => d.Date.Date == currentSchedule.Date);
                    data = new object[]
                    {
                       currentSchedule.Date.ToString("dd-MM-yyyy"),
                        currentSchedule.TimeOfDay == TimeOfDay.Morning ? "Poranna" : "Popołudniowa",
                        isDayOff ? "TAK" : "NIE"
                    };
                    counter++;
                    var index = WorkSchedule_DGV.Rows.Add(data);
                    WorkSchedule_DGV.Rows[index].DefaultCellStyle.BackColor = isDayOff ? Color.YellowGreen : Color.OrangeRed;
                }
                else
                {
                    isSubstitution = User.Substitutions.Any(s => s.Date == i.Date);

                    data = new object[]
                    {
                        i.ToString("dd-MM-yyyy"),
                        isSubstitution ? "Zastępstwo" : "Wolne",
                        "NIE"
                    };
                    var index = WorkSchedule_DGV.Rows.Add(data);
                    WorkSchedule_DGV.Rows[index].DefaultCellStyle.BackColor = isSubstitution ? Color.Yellow : Color.SpringGreen;
                }

            }
        }


    }
}
