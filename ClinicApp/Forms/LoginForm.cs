using ClinicApp.Entities;
using ClinicApp.Enums;
using ClinicApp.Forms;
using ClinicApp.Forms.AdministratorForms;
using ClinicApp.Forms.ManagerForms;
using ClinicApp.Forms.ReceptionistForms;
using ClinicApp.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;

namespace ClinicApp
{
    public partial class LoginForm : Form
    {
        private readonly ClinicDbContext _dbContext;
        private readonly IPasswordHasher<User> _passwordHasher;
        private readonly IUserRepository _userRepository;
        private readonly IServiceProvider _serviceProvider;
        private readonly IDayOffTypeRepository _dayOffTypeRepository;

        public LoginForm(ClinicDbContext dbContext,
            IPasswordHasher<User> passwordHasher,
            IUserRepository userRepository,
            IServiceProvider serviceProvider
          )
        {
            InitializeComponent();
            _dbContext = dbContext;
            _passwordHasher = passwordHasher;
            _userRepository = userRepository;
            _serviceProvider = serviceProvider;
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

        private async Task<User> Login()
        {
            var user = await _userRepository.GetUserByLoginWithRole(Login_TB.Text);
            if (user is null)
            {
                MessageBox.Show("Nieprawidlowy login lub haslo");
                return null;
            }
            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, Password_TB.Text);
            if (result is PasswordVerificationResult.Failed)
            {
                MessageBox.Show("Nieprawidlowy login lub haslo");
                return null;
            }
            return user;
        }
        private async void Login_BTN_Click(object sender, EventArgs e)
        {
            var user = await Login();
            if (user is null) return;
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
    }
}