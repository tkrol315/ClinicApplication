using ClinicApp.Commands.AssignWorker;
using ClinicApp.Dtos;
using ClinicApp.Queries.GetWorkersAvailableForSubstituion;
using MediatR;

namespace ClinicApp.Forms.ManagerForms
{
    public partial class AssignSubstitutionForm : Form
    {
        private readonly IMediator _mediator;
        public int SubstitutionId { get; set; }
        public AssignSubstitutionForm(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        public async Task LoadAvailableWorkers()
        {
            var query = new GetWorkersAvailableForSubstitutionQuery(SubstitutionId);
            var availableWorkers = await _mediator.Send(query);
            var dtoList = new List<AvailableWorkerDto>();
            foreach (var worker in availableWorkers)
            {
                var dto = new AvailableWorkerDto()
                {
                    Id = worker.Id,
                    FullName = worker.Name + " " + worker.Surname
                };
                dtoList.Add(dto);
            }
            AssignWorker_CB.DataSource = dtoList;
            AssignWorker_CB.DisplayMember = "FullName";
            AssignWorker_CB.ValueMember = "Id";
            if (AssignWorker_CB.Items.Count < 0)
            {
                MessageBox.Show("Nie znaleziono dostępnych pracowników");
                Close();
            }
            else
                AssignWorker_CB.SelectedIndex = 0;

        }

        private async void AssignWorker_BTN_Click(object sender, EventArgs e)
        {
            var selectedItem = (AvailableWorkerDto)AssignWorker_CB.SelectedItem;
            var workerId = selectedItem.Id;
            var command = new AssignWorkerToSubstitutionCommand(SubstitutionId, workerId);
            await _mediator.Send(command);
            Close();

        }
    }
}
