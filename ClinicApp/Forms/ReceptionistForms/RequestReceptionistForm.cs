using ClinicApp.Entities;
using ClinicApp.Queries.ReceptionisQueries.GetUserSchedules;
using ClinicApp.Seeders;
using MediatR;
using System.Runtime.CompilerServices;

namespace ClinicApp.Forms.ReceptionistForms
{
    public partial class RequestReceptionistForm : Form
    {
        private Request request;
        private List<Schedule> schedules;
        private readonly IMediator _mediator;
        public RequestReceptionistForm(IMediator mediator)
        {
            _mediator = mediator;

            InitializeComponent();


        }
        public async Task Load(Request request)
        {
            this.request = request;
            RequestContent_RTB.Text = request.Message;
            var query = new GetUserSchedulesQuary(request.UserId);
            schedules = await _mediator.Send(query);
            AdjustDates();
        }

        private void AdjustDates()
        {
            foreach (var schedule in schedules)
            {
                RequestDateFrom_CB.Items.Add(schedule.Date.Date.ToString("dd-MM-yyyy") + " " + schedule.TimeOfDay.ToString());
            }
        }

        private void DateFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequestDateTo_CB.Items.Clear();
            var selectedScheduleDate = Convert.ToDateTime(RequestDateFrom_CB.SelectedItem.ToString().Substring(0,10));
            MessageBox.Show(selectedScheduleDate.Date.ToString("dd-MM-yyyy"));
            foreach(var schedule in schedules)
            {
                if(schedule.Date > selectedScheduleDate && selectedScheduleDate.AddDays(request.User.DaysOffPull) >= schedule.Date)
                {
                    RequestDateTo_CB.Items.Add(schedule.Date.Date.ToString("dd-MM-yyyy") + " " + schedule.TimeOfDay.ToString());
                }
            }
        }
    }
}
