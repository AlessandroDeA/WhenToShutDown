using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace WhenToShutDown
{
    public partial class Form_SD : Form
    {

        public int caso;
        private readonly ShutDownService _shutdownService = new ShutDownService();
        public Form_SD()
        {
            InitializeComponent();
        }

        private void btnNowTime_Click(object sender, EventArgs e)
        {
            int minNowAdd = (int)udMinNow.Value;
            _shutdownService.ScheduleShutdown(minNowAdd);
            caso = 1;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _shutdownService.CancelShutdown();  
        }                               

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            switch (caso) 
            {
                case 1:
                    _shutdownService.ExecuteShutdown();
                    break;
                case 2:
                    if (cbTime.Checked) 
                    {
                        int hour = (int)udHrs.Value;
                        int min = (int)udMin.Value;
                        _shutdownService.ScheduleShutdownTime(hour, min);
                    }
                    break;
            }
        }

        private void cbTime_CheckedChanged(object sender, EventArgs e)
        {
            udHrs.Enabled = (cbTime.CheckState == CheckState.Checked);
            udMin.Enabled = (cbTime.CheckState == CheckState.Checked);
            if (cbTime.Checked)
            {
                btnNowTime.Enabled = false;
                udMinNow.Enabled = false;
                dtPicker.Enabled = false;
                caso = 2;
            }
            else 
            {
                btnNowTime.Enabled = true;
                udMinNow.Enabled = true;
                dtPicker.Enabled = true;
            }
        }

        private void Form_SD_Load(object sender, EventArgs e)
        {
            udHrs.Enabled = false;
            udMin.Enabled = false;
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "HH:mm dd/MM/yyyy";
        }
    }
}
