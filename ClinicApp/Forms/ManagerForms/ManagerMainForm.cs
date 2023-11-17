using ClinicApp.Commands;
using ClinicApp.Commands.AcceptRequestCommand;
using ClinicApp.Commands.RejectRequest;
using ClinicApp.Entities;
using ClinicApp.Queries.GetAllRequestsByStateId;
using ClinicApp.Queries.GetAllRequestsByStateIds;
using ClinicApp.Queries.GetUserDaysOff;
using ClinicApp.Queries.GetUserSchedules;
using ClinicApp.Services.LogoutService;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ClinicApp.Forms.ManagerForms
{
    public partial class ManagerMainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IMediator _mediator;
        private readonly ILogoutService _logoutService;
        public List<Request> Requests { get; set; }
        public ManagerMainForm(
            IServiceProvider serviceProvider,
            IMediator mediator,
            ILogoutService logoutService)
        {
            _serviceProvider = serviceProvider;
            _mediator = mediator;
            _logoutService = logoutService;
            InitializeComponent();
            LoadRequests();
        }
        private async Task LoadRequestsHistroy()
        {
            RequestHistory_DGV.Rows.Clear();
            var quary = new GetAllRequestsByStateIdsQuary(new int[] { 2, 4 });
            var requests = await _mediator.Send(quary);

            foreach (var request in requests)
            {
                object[] data =
                    {
                    request.User.Name,
                    request.User.Surname,
                    request.From.ToString("dd-MM-yyyy"),
                    request.To.ToString("dd-MM-yyyy"),
                    request.DayOffType.Name
                };
                int index = RequestHistory_DGV.Rows.Add(data);
                if (request.RequestStateId == 4)
                    RequestHistory_DGV.Rows[index].DefaultCellStyle.BackColor = Color.SpringGreen;
                else
                    RequestHistory_DGV.Rows[index].DefaultCellStyle.BackColor = Color.OrangeRed;

            }

        }
        private async void LoadRequests()
        {
            RequestManager_DGV.Rows.Clear();
            var quary = new GetAllRequestsByStateIdQuery(3);
            Requests = await _mediator.Send(quary);

            foreach (var request in Requests)
            {
                object[] data =
                    { request.Id,
                    request.From.ToString("dd-MM-yyyy"),
                    request.To.ToString("dd-MM-yyyy") };
                RequestManager_DGV.Rows.Add(data);
            }
        }

        private async void AcceptRejectRequestManager_BTN_Click(object sender, EventArgs e)
        {
            if (RequestManager_DGV.SelectedRows.Count > 0)
            {
                var selectedRequestCell = RequestManager_DGV.SelectedRows[0].Cells[0].Value;
                if (int.TryParse(selectedRequestCell.ToString(), out var selectedRequestId))
                {
                    var request = Requests.FirstOrDefault(r => r.Id == selectedRequestId);
                    var button = (Button)sender;
                    IManagerChoiceCommand command;

                    if (button.Name == "AcceptRequestManager_BTN")
                        command = new AcceptRequestCommand(request);
                    else
                        command = new RejectRequestCommand(request);
                    await _mediator.Send(command);
                    LoadRequests();
                    MessageBox.Show(command.GetType().Name == "AcceptRequestCommand" ?
                          $"Dzień wolny od {request.From.ToString("dd-MM-yyyy")} do {request.To.Date.ToString("dd-MM-yyyy")}" :
                          "Wniosek odrzucony");
                }

                else
                {
                    MessageBox.Show("Coś poszło nie tak");
                }
            }
            else
                MessageBox.Show("Nie zaznaczono komórki");
        }

        private async void ShowSchedule_BTN_Click(object sender, EventArgs e)
        {
            //var scheduleForm = _serviceProvider.GetRequiredService<WorkScheduleForm>();
            //scheduleForm.Text = $"Grafik - {request.User.Name} {request.User.Surname}";
            //var quarySchadules = new GetUserSchedulesQuary(request.UserId);
            //var quaryDaysOff = new GetUserDaysOffQuary(request.UserId);
            //scheduleForm.UserSchedules = await _mediator.Send(quarySchadules);
            //scheduleForm.DaysOff = await _mediator.Send(quaryDaysOff);
            //scheduleForm.FillDGV();
            //scheduleForm.ShowDialog();
            if (RequestManager_DGV.SelectedRows.Count > 0)
            {
                var selectedRequestCell = RequestManager_DGV.SelectedRows[0].Cells[0].Value;
                if (int.TryParse(selectedRequestCell.ToString(), out var selectedRequestId))
                {
                    var request = Requests.FirstOrDefault(r => r.Id == selectedRequestId);
                    var scheduleForm = _serviceProvider.GetRequiredService<WorkScheduleForm>();
                    scheduleForm.Text = $"Grafik - {request.User.Name} {request.User.Surname}";
                    var schdulesQuary = new GetUserSchedulesQuary(request.UserId);
                    var daysOffQuary = new GetUserDaysOffQuary(request.UserId);
                    scheduleForm.UserSchedules = await _mediator.Send(schdulesQuary);
                    scheduleForm.DaysOff = await _mediator.Send(daysOffQuary);
                    scheduleForm.FillDGV();
                    scheduleForm.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Coś poszło nie tak");
                }
            }
            else
                MessageBox.Show("Nie zaznaczono komórki");
        }

        private void ManagerLogout_BTN_Click(object sender, EventArgs e)
        {
            _logoutService.LogoutOut(sender, e, this);
        }

        private async void ManagerTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ManagerTabControl.SelectedIndex;
            if (selectedIndex == 1)
                await LoadRequestsHistroy();
        }
    }
}
