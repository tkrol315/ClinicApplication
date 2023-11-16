using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Services.LogoutService
{
    public class LogoutService : ILogoutService
    {
        private readonly IServiceProvider _serviceProvider;
        public LogoutService(IServiceProvider serviceProvider)
        {

            _serviceProvider = serviceProvider;

        }
        public void LogoutOut(object sender, EventArgs e, Form form)
        {
            var loginForm = _serviceProvider.GetRequiredService<LoginForm>();
            form.Hide();
            loginForm.FormClosed += (sender, e) => Application.Exit();
            loginForm.Show();
        }
    }
}
