using ClinicApp.Commands.CreateRequest;
using ClinicApp.Queries.GetAllWorkerRequests;
using ClinicApp.Queries.GetRejectionMessageByRequestId;
using ClinicApp.Repositories.Interfaces;
using ClinicApp.Services.LogoutService;
using MediatR;

namespace ClinicApp.Forms
{
    public partial class BasicWorkerApplicationForm : Form
    {
        private readonly IDayOffTypeRepository _dayOffTypeRepository;
        private readonly IMediator _mediator;
        private readonly ILogoutService _logoutService;
        private readonly Color _rejectedNotificationColor = Color.OrangeRed;
        public BasicWorkerApplicationForm(
            IDayOffTypeRepository dayOffTypeRepository,
            IMediator mediator,
            ILogoutService logoutService)
        {
            _dayOffTypeRepository = dayOffTypeRepository;
            _mediator = mediator;
            InitializeComponent();
            LoadAsyncData();
            _logoutService = logoutService;
        }

        private async void LoadAsyncData()
        {
            await LoadDayOffTypes();
            await LoadRequestToNotificationPanel();
        }
        public async Task LoadDayOffTypes()
        {
            var dayOffTypeNames = await _dayOffTypeRepository.GetAllNames();
            foreach (var name in dayOffTypeNames)
            {
                BasicWorkerDayoffType_CB.Items.Add(name);
            }
            BasicWorkerDayoffType_CB.SelectedIndex = 0;
        }

        private async void SendRequest_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                var command = new CreateRequestCommand(RequestContent_RTB.Text,
                    BasicWorkerDayoffType_CB.Text, UserSession.CurrentUser.Id);
                var createdRequest = await _mediator.Send(command);
                await LoadRequestToNotificationPanel();
                MessageBox.Show("Wniosek został wysłany");
                RequestContent_RTB.Text = "";

            }
            catch (Exception)
            {
                MessageBox.Show("Nie udalo sie wyslac wniosku");
            }


        }

        public async Task LoadRequestToNotificationPanel()
        {
            WorkerNotificatin_DGV.Rows.Clear();
            var quary = new GetAllWorkerRequestsQuary(UserSession.CurrentUser.Id);
            var requests = await _mediator.Send(quary);
            foreach (var request in requests)
            {
                object[] data = { request.Id, request.DayOffType.Name, request.RequestState.Message };
                int rowIndex = WorkerNotificatin_DGV.Rows.Add(data);
                switch (request.RequestState.Id)
                {
                    case 1:
                        WorkerNotificatin_DGV.Rows[rowIndex].DefaultCellStyle.BackColor = Color.PeachPuff;
                        break;
                    case 2:
                        WorkerNotificatin_DGV.Rows[rowIndex].DefaultCellStyle.BackColor = _rejectedNotificationColor;
                        break;
                    case 3:
                        WorkerNotificatin_DGV.Rows[rowIndex].DefaultCellStyle.BackColor = Color.PaleGoldenrod;
                        break;
                    case 4:
                        WorkerNotificatin_DGV.Rows[rowIndex].DefaultCellStyle.BackColor = Color.SpringGreen;
                        break;
                }
            }
        }

        private async void PreviewRejectionMessage_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (WorkerNotificatin_DGV.Rows[rowIndex].DefaultCellStyle.BackColor == _rejectedNotificationColor)
            {
                var requestId = Convert.ToInt32(WorkerNotificatin_DGV.Rows[rowIndex].Cells["RequestNumber"].Value);
                var query = new GetRejectionMessageByRequestIdQuary(requestId);
                var message = await _mediator.Send(query);
                MessageBox.Show("Powód odrzucenia: " + message);
            }
        }

        private void LogoutWorker_BTN_Click(object sender, EventArgs e)
        {
            _logoutService.LogoutOut(sender, e, this);
        }
    }
}
