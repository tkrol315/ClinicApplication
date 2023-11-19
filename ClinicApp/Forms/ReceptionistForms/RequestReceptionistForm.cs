using ClinicApp.Commands.SendAcceptedReceptionistRequest;
using ClinicApp.Commands.SendRejectReceptionistRequest;
using ClinicApp.Entities;
using ClinicApp.Queries.GetUserAvailableSchedules;
using ClinicApp.Queries.GetUserSubstitutions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ClinicApp.Forms.ReceptionistForms
{
    public partial class RequestReceptionistForm : Form
    {
        private Request request;
        private List<Schedule> schedules;
        private readonly IMediator _mediator;
        private readonly IServiceProvider _serviceProvider;
        public RequestReceptionistForm(IMediator mediator, IServiceProvider serviceProvider)
        {
            _mediator = mediator;
            _serviceProvider = serviceProvider;
            InitializeComponent();


        }
        public async Task LoadForm(Request request)
        {
            this.request = request;
            RequestContent_RTB.Text = request.Message;
            var query = new GetUserAvailableSchedulesQuery(request.UserId);
            schedules = await _mediator.Send(query);
            FillFromDateComboBox();
        }

        private void FillFromDateComboBox()
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

            schedules.RemoveAll(s => s.Date < selectedScheduleDate.Date);

            foreach (var s in schedules)
            {
                if (request.DayOffTypeId == 1 && RequestDateTo_CB.Items.Count < request.User.DaysOffPull)
                {
                    RequestDateTo_CB.Items.Add(s.ToString());
                }
                else if (request.DayOffTypeId == 2)
                {
                    RequestDateTo_CB.Items.Add(s.ToString());
                }
                else if (request.DayOffTypeId == 3 && RequestDateTo_CB.Items.Count < request.User.DaysOffOnDemandPull)
                {
                    RequestDateTo_CB.Items.Add(s.ToString());
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
                var command = new SendAcceptedReceptionistRequestCommand(
                    request,
                    GetDateFromComboBox(RequestDateFrom_CB),
                    GetDateFromComboBox(RequestDateTo_CB));
                await _mediator.Send(command);
                MessageBox.Show("Wniosek został przesłany");
                Close();
            }
            else if (RejectRequest_RB.Checked && RequestReply_RTB.TextLength > 0)
            {
                var command = new SendRejectReceptionistRequestCommand(RequestReply_RTB.Text, request);
                await _mediator.Send(command);
                MessageBox.Show("Wniosek został odrzucony");
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

        private async void ShowSchedule_BTN_Click(object sender, EventArgs e)
        {
            var scheduleForm = _serviceProvider.GetRequiredService<WorkScheduleForm>();
            scheduleForm.Text = $"Grafik - {request.User.Name} {request.User.Surname}";
            var query = new GetUserWithSchedulesSubstitutionsAndDaysOffQuery(request.UserId);
            scheduleForm.User = await _mediator.Send(query);
            scheduleForm.FillDGV();
            scheduleForm.ShowDialog();
        }
    }
}
