using ClinicApp.Entities;
using ClinicApp.Forms;
using ClinicApp.Forms.AdministratorForms;
using ClinicApp.Forms.ManagerForms;
using ClinicApp.Forms.ReceptionistForms;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ClinicApp
{
    public partial class LoginForm : Form
    {
        private readonly ClinicDbContext _dbContext;
        private readonly IPasswordHasher<User> _passwordHasher;
        public User LoggedUser { get; set; }

        public LoginForm(ClinicDbContext dbContext, IPasswordHasher<User> passwordHasher)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _passwordHasher = passwordHasher;
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

        private async Task<bool> Login()
        {
            var user = await _dbContext.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Login == Login_TB.Text);
            if (user is null)
            {
                MessageBox.Show("Nieprawidlowy login lub haslo");
                return false;
            }
            var result = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, Password_TB.Text);
            if (result is PasswordVerificationResult.Failed)
            {
                MessageBox.Show("Nieprawidlowy login lub haslo");
                return false;
            }
            LoggedUser = user;
            MessageBox.Show("Udalo sie zalogowac");
            return true;
        }
        private async void Login_BTN_Click(object sender, EventArgs e)
        {
            var result = await Login();
           
            //var bwf = new BasicWorkerApplicationForm();
            // bwf.ShowDialog();
            // var raf = new ReceptionistApplicationForm();
            // raf.ShowDialog();
            // var rrf = new RequestReceptionistForm();
            // rrf.ShowDialog();
            // var wsf = new WorkScheduleForm(); 
            // wsf.ShowDialog();
            // var mmf = new ManagerMainForm();
            // mmf.ShowDialog();
            // var asf = new AssignSubstitutionForm();
            // asf.ShowDialog();
            // var maf = new MainAdministratorForm();
            // maf.ShowDialog();
            // var ewf = new EditWorkerForm(); 
            // ewf.ShowDialog();

        }
    }
}