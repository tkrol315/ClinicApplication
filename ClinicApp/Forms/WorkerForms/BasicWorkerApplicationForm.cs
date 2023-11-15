using ClinicApp.Commands.WorkerCommands.CreateRequest;
using ClinicApp.Entities;
using ClinicApp.Queries.ReceptionisQueries.GetAllRequests;
using ClinicApp.Queries.WorkerQueries.GetAllWorkerRequests;
using ClinicApp.Queries.WorkerQueries.GetRejectionMessage;
using ClinicApp.Repositories.Interfaces;
using MediatR;

namespace ClinicApp.Forms
{
    public partial class BasicWorkerApplicationForm : Form
    {
        private readonly IDayOffTypeRepository _dayOffTypeRepository;
        private readonly IMediator _mediator;

        public BasicWorkerApplicationForm(IDayOffTypeRepository dayOffTypeRepository,
            IMediator mediator)
        {
            _dayOffTypeRepository = dayOffTypeRepository;
            _mediator = mediator;
            InitializeComponent();
            LoadAsyncData();

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
                        WorkerNotificatin_DGV.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Orange;
                        break;
                    case 2:
                        WorkerNotificatin_DGV.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                        break;
                    case 3:
                        WorkerNotificatin_DGV.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    case 4:
                        WorkerNotificatin_DGV.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                }
            }
        }

        private async void PreviewRejectionMessage_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (WorkerNotificatin_DGV.Rows[rowIndex].DefaultCellStyle.BackColor == Color.Red)
            {
                var requestId = Convert.ToInt32(WorkerNotificatin_DGV.Rows[rowIndex].Cells["RequestNumber"].Value);
                var query = new GetRejectionMessageByRequestIdQuary(requestId);
                var message = await _mediator.Send(query);
                MessageBox.Show("Powód odrzucenia: " + message);
            }
        }

      
    }
}
