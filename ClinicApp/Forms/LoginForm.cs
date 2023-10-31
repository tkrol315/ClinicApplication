using ClinicApp.Forms;
using ClinicApp.Forms.AdministratorForms;
using ClinicApp.Forms.ManagerForms;
using ClinicApp.Forms.ReceptionistForms;
using System.ComponentModel.DataAnnotations;

namespace ClinicApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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

        private void Login_BTN_Click(object sender, EventArgs e)
        {
           var bwf = new BasicWorkerApplicationForm();
            bwf.ShowDialog();
            var raf = new ReceptionistApplicationForm();
            raf.ShowDialog();
            var rrf = new RequestReceptionistForm();
            rrf.ShowDialog();
            var wsf = new WorkScheduleForm(); 
            wsf.ShowDialog();
            var mmf = new ManagerMainForm();
            mmf.ShowDialog();
            var asf = new AssignSubstitutionForm();
            asf.ShowDialog();
            var maf = new MainAdministratorForm();
            maf.ShowDialog();
            var ewf = new EditWorkerForm(); 
            ewf.ShowDialog();
        }
    }
}