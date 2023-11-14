using ClinicApp.Commands.WorkerCommands.CreateRequest;
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
            LoadDayOffTypes();
        }


        private async void LoadDayOffTypes()
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
                var result = await _mediator.Send(command);
                MessageBox.Show("Wniosek został wysłany");
            }
            catch (Exception)
            {
                MessageBox.Show("Nie udalo sie wyslac wniosku");
            }
          
        
        }
    }
}
