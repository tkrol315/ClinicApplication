using Accessibility;
using ClinicApp.Commands.AcceptUserDetails;
using ClinicApp.Entities;
using MediatR;

namespace ClinicApp.Forms.AdministratorForms
{
    public partial class EditWorkerForm : Form
    {
        private readonly IMediator _mediator;
        public User CurrentUser { get; set; }
        public EditWorkerForm(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
            MaximizeBox = false;
        }
        public void LoadUserDetails(User user)
        {
            CurrentUser = user;
            Login_TB.Text = user.Login;
            Name_TB.Text = user.Name;
            Surname_TB.Text = user.Surname;
            DaysOff_TB.Text = user.DaysOffPull.ToString();
        }

        private void DaysOff_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void EditWorker_BTN_Click(object sender, EventArgs e)
        {
            if (Login_TB.Text == string.Empty ||
                Name_TB.Text == string.Empty ||
                Surname_TB.Text == string.Empty ||
                DaysOff_TB.Text == string.Empty)
            {
                MessageBox.Show("Wszystkie pola muszą pozostać uzupełnione");
                return;
            }
            try
            {
                var command = new AcceptUserDetailsCommand(
                      CurrentUser,
                      Login_TB.Text,
                      Name_TB.Text,
                      Surname_TB.Text,
                      int.Parse(DaysOff_TB.Text)
                );
                await _mediator.Send(command);
                MessageBox.Show($"Dane użytkownika: {CurrentUser.Login}, zostały zmienione");
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
