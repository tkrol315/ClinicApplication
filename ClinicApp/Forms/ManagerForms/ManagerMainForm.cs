using ClinicApp.Entities;
using ClinicApp.Queries.ReceptionisQueries.GetAllRequests;
using MediatR;

namespace ClinicApp.Forms.ManagerForms
{
    public partial class ManagerMainForm : Form
    {
        private readonly IMediator _mediator;
        public List<Request> Requests { get; set; }
        public ManagerMainForm(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
            LoadRequest();
        }

        private async void LoadRequest()
        {
            var quary = new GetAllReceptionistRequestsQuery(3);
            Requests = await _mediator.Send(quary);
        }
    }
}
