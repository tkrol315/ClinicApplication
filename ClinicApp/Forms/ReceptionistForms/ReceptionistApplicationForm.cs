using ClinicApp.Entities;
using ClinicApp.Forms.ReceptionistForms;
using ClinicApp.Queries.GetAllRequestsByStateId;
using ClinicApp.Services.LogoutService;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace ClinicApp.Forms
{
    public partial class ReceptionistApplicationForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IMediator _mediator;
        private readonly ILogoutService _logoutService;
        private List<Request> requests;
        public ReceptionistApplicationForm(IMediator mediator,
            IServiceProvider serviceProvider,
            ILogoutService logoutService)
        {
            _mediator = mediator;
            _serviceProvider = serviceProvider;
            _logoutService = logoutService;
            InitializeComponent();
            LoadRequests();
        }

        private async void LoadRequests()
        {
            var getRequestsQuery = new GetAllRequestsByStateIdQuery(1);
            requests = await _mediator.Send(getRequestsQuery);
            Request_DGV.Rows.Clear();
            foreach (var request in requests)
            {
                object[] data = { request.Id, request.User.Name, request.User.Surname, request.DayOffType.Name };
                Request_DGV.Rows.Add(data);
            }
        }

        private async void Rquest_Click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = Request_DGV.SelectedRows[0];
            int id = Convert.ToInt32(selectedRow.Cells["RequestNumber"].Value);
            var clickedRequest = requests.Single(r => r.Id == id);
            var requestForm = _serviceProvider.GetRequiredService<RequestReceptionistForm>();
            await requestForm.Load(clickedRequest);
            requestForm.ShowDialog();
            LoadRequests();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _logoutService.LogoutOut(sender, e, this);
        }
    }
}
