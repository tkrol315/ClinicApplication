using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Services.LogoutService
{
    public interface ILogoutService
    {
        void LogoutOut(object sender, EventArgs e, Form form);
    }
}
