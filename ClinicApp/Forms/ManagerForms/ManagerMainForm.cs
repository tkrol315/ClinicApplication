using ClinicApp.Commands.ManagerCommands;
using ClinicApp.Entities;
using ClinicApp.Queries.GetAllRequestsByStateId;
using ClinicApp.Services.LogoutService;
using MediatR;

namespace ClinicApp.Forms.ManagerForms
{
    public partial class ManagerMainForm : Form
    {
        private readonly IMediator _mediator;
        private readonly ILogoutService _logoutService;
        public List<Request> Requests { get; set; }
        public ManagerMainForm(
            IMediator mediator,
            ILogoutService logoutService)
        {
            _mediator = mediator;
            _logoutService = logoutService;
            InitializeComponent();
            LoadRequest();
        }

        private async void LoadRequest()
        {
            RequestManager_DGV.Rows.Clear();
            var quary = new GetAllRequestsByStateIdQuery(3);
            Requests = await _mediator.Send(quary);

            foreach (var request in Requests)
            {
                object[] data = { request.Id, request.From.ToString("dd-MM-yyyy"), request.To.ToString("dd-MM-yyyy") };
                RequestManager_DGV.Rows.Add(data);
            }
        }

        private async void AcceptRequestManager_BTN_Click(object sender, EventArgs e)
        {
            if (RequestManager_DGV.SelectedRows.Count > 0)
            {
                var selectedRequestCell = RequestManager_DGV.SelectedRows[0].Cells[0].Value;
                if (int.TryParse(selectedRequestCell.ToString(), out var selectedRequestId))
                {
                    var request = Requests.FirstOrDefault(r => r.Id == selectedRequestId);
                    var command = new AcceptRequestCommand(request);
                    await _mediator.Send(command);
                    LoadRequest();
                    MessageBox.Show($"Dzień wolny od {request.From.ToString("dd-MM-yyyy")} do {request.To.Date.ToString("dd-MM-yyyy")}");
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
    }
}
