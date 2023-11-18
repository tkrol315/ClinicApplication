using ClinicApp.Commands.LoginUser;
using ClinicApp.Entities;
using ClinicApp.Enums;
using ClinicApp.Forms;
using ClinicApp.Forms.AdministratorForms;
using ClinicApp.Forms.ManagerForms;
using ClinicApp.Repositories.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace ClinicApp
{
    public partial class LoginForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IMediator _mediator;

        public LoginForm(
            IServiceProvider serviceProvider,
            IMediator mediator
          )
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _mediator = mediator;
            MaximizeBox = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCB.Checked)
            {
                Password_TB.UseSystemPasswordChar = false;
            }
            else
                Password_TB.UseSystemPasswordChar = true;
        }
        private async void Login_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                var command = new LoginUserCommand(Login_TB.Text, Password_TB.Text);
                var user = await _mediator.Send(command);
                UserSession.CurrentUser = user;
                var startForm = user.Role.StartForm;
                Form form;
                switch (startForm)
                {
                    case StartForm.BasicWorkerApplicationForm:
                        form = _serviceProvider.GetRequiredService<BasicWorkerApplicationForm>();
                        break;
                    case StartForm.ReceptionistApplicationForm:
                        form = _serviceProvider.GetRequiredService<ReceptionistApplicationForm>();
                        break;
                    case StartForm.ManagerMainForm:
                        form = _serviceProvider.GetRequiredService<ManagerMainForm>();
                        break;
                    case StartForm.MainAdministratorForm:
                        form = _serviceProvider.GetRequiredService<MainAdministratorForm>();
                        break;
                    default:
                        return;
                }
                Hide();
                form.FormClosed += (sender, e) => Application.Exit();
                form.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Nieprawidlowy login lub haslo");
            }
        }
    }
}