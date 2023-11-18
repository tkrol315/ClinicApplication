using ClinicApp.Queries.GetAllUsers;
using ClinicApp.Queries.GetUserById;
using ClinicApp.Services.LogoutService;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp.Forms.AdministratorForms
{
    public partial class MainAdministratorForm : Form
    {
        private readonly IMediator _mediator;
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogoutService _logoutService;
        public MainAdministratorForm(
            IMediator mediator,
            IServiceProvider serviceProvider,
            ILogoutService logoutService)
        {
            _mediator = mediator;
            _serviceProvider = serviceProvider;
            _logoutService = logoutService;
            InitializeComponent();
            LoadUsers();
        }
        private async void LoadUsers()
        {
            AdministratorPanel_DGV.Rows.Clear();
            var query = new GetAllUsersWithRolesQuery();
            var users = await _mediator.Send(query);
            foreach (var user in users)
            {
                object[] data =
                {
                    user.Id,
                    user.Login,
                    user.Name,
                    user.Surname,
                    user.DaysOffPull,
                    user.Role.Name
                };
                AdministratorPanel_DGV.Rows.Add(data);
            }
        }

        private async void AdministratorPanel_DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AdministratorPanel_DGV.SelectedCells.Count > 0)
            {
                var selectedRow = AdministratorPanel_DGV.SelectedRows[0];
                var userId = int.Parse(selectedRow.Cells[0].Value.ToString());
                var query = new GetUserByIdQuery(userId);
                var user = await _mediator.Send(query);
                var editWorkerForm = _serviceProvider.GetRequiredService<EditWorkerForm>();
                editWorkerForm.LoadUserDetails(user);
                editWorkerForm.ShowDialog();
                LoadUsers();
            }
        }

        private void AdminLogout_BTN_Click(object sender, EventArgs e)
        {
            _logoutService.LogoutOut(sender, e, this);
        }
    }
}
