using ClinicApp.Commands.ReceptionistCommands.SendAcceptedReceptionistRequest;
using ClinicApp.Entities;
using ClinicApp.Queries.ReceptionisQueries.GetUserSchedules;
using MediatR;

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
            AdjustDayOffComboBox();
        }

        private void AdjustDayOffComboBox()
        {
            foreach (var schedule in schedules)
            {
                RequestDateFrom_CB.Items.Add(schedule.ToString());
            }

        }


        private void DateFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            RequestDateTo_CB.Items.Clear();
            var selectedScheduleDate = GetDateFromComboBox(RequestDateFrom_CB);
            if (request.DayOffTypeId == 1)
            {
                foreach (var schedule in schedules)
                {
                    if (schedule.Date >= selectedScheduleDate && RequestDateTo_CB.Items.Count < request.User.DaysOffPull)
                    {
                        RequestDateTo_CB.Items.Add(schedule.ToString());
                    }
                }
            }
            else if (request.DayOffTypeId == 2)
            {
                foreach (var schedule in schedules)
                {
                    if (schedule.Date >= selectedScheduleDate)
                    {
                        RequestDateTo_CB.Items.Add(schedule.ToString());
                    }

                }
            }
            else if (request.DayOffTypeId == 3)
            {
                foreach (var schedule in schedules)
                {
                    if (schedule.Date > selectedScheduleDate && RequestDateTo_CB.Items.Count <= request.User.DaysOffOnDemandPull)
                    {
                        RequestDateTo_CB.Items.Add(schedule.ToString());
                    }
                }
            }
        }

        private void RadioButton_State_Changed(object sender, EventArgs e)
        {
            if (AcceptRequest_RB.Checked)
            {
                RequestReply_RTB.Enabled = false;
            }
            else
                RequestReply_RTB.Enabled = true;
        }

        private async void Send_BTN_Click(object sender, EventArgs e)
        {

            if (AcceptRequest_RB.Checked &&
                RequestDateFrom_CB.SelectedItem is not null &&
                RequestDateTo_CB.SelectedItem is not null)
            {

                var command = new SendAcceptedReceptionistRequestCommand(request,
                    GetDateFromComboBox(RequestDateFrom_CB),
                    GetDateFromComboBox(RequestDateTo_CB));
                await _mediator.Send(command);
                MessageBox.Show("Wniosek został przesłany");
                Close();
            }
            else if (RejectRequest_RB.Checked && RequestReply_RTB.TextLength > 0)
            {

                Close();
            }
            else
            {
                MessageBox.Show("Musisz uzupełnić wszystkie pola");
            }
            

        }

        private DateTime GetDateFromComboBox(ComboBox cb)
        {
            return Convert.ToDateTime(cb.SelectedItem.ToString().Substring(0, 10));

        }
    }
}
