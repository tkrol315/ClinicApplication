using ClinicApp.Entities;
using ClinicApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp.Forms
{
    public partial class BasicWorkerApplicationForm : Form
    {
        private readonly IDayOffTypeRepository _dayOffTypeRepository;

        public BasicWorkerApplicationForm(IDayOffTypeRepository dayOffTypeRepository)
        {
            _dayOffTypeRepository = dayOffTypeRepository;
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

    }
}
