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

        private void btnStop_Click(object sender, EventArgs e)
        {
            _shutdownService.CancelShutdown();  
        }                               

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            switch (caso)
            { 
                case 1:
                    int minNowAdd = (int)udMinNow.Value;
                    _shutdownService.ExecuteShutdown(minNowAdd);
                    break;
                case 2:
                    if (tbTime.Checked) 
                    {
                        int hour = (int)udHrs.Value;
                        int min = (int)udMin.Value;
                        _shutdownService.ScheduleShutdownTime(hour, min);
                    }
                    break;
                case 3:
                    DateTime chagedDay = dtPicker.Value;
                    _shutdownService.ScheduleShutdownDay(chagedDay);
                    break;
                case 4:
                    int hourNowAdd = (int)udHours.Value;
                    _shutdownService.ScheduleShutdownHour(hourNowAdd);
                    break;
            }
        }

        private void Form_SD_Load(object sender, EventArgs e)
        {
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "HH:mm dd/MM/yyyy";
        }

        private void tbMinutes_CheckedChanged(object sender, EventArgs e)
        {
            if (tbMinutes.Checked)
            {
                boxDate.Enabled = false;
                boxHour.Enabled = false;
                boxTime.Enabled = false;
                caso = 1;
            }
            else 
            {
                boxDate.Enabled = true;
                boxHour.Enabled = true;
                boxTime.Enabled = true;
                _shutdownService.CancelShutdown();
            }
        }

        private void tbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (tbTime.Checked)
            {
                boxDate.Enabled = false;
                boxHour.Enabled = false;
                boxMinutes.Enabled = false;
                caso = 2;
            }
            else
            {
                boxDate.Enabled = true;
                boxHour.Enabled = true;
                boxMinutes.Enabled = true;
                _shutdownService.CancelShutdown();

            }
        }

        private void tbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (tbDate.Checked) 
            {
                boxHour.Enabled = false;
                boxTime.Enabled = false;
                boxMinutes.Enabled=false;
                caso = 3;
            }
            else
            {
                boxHour.Enabled= true;
                boxTime.Enabled= true;
                boxMinutes.Enabled=true;
                _shutdownService.CancelShutdown();
            }
        }

        private void tbHours_CheckedChanged(object sender, EventArgs e)
        {
            if (tbHours.Checked)
            {
                boxMinutes.Enabled = false;
                boxDate.Enabled = false;
                boxTime.Enabled = false;
                caso = 4;
            }
            else 
            {
                boxMinutes.Enabled = true;
                boxDate.Enabled = true;
                boxTime.Enabled = true;
                _shutdownService.CancelShutdown();
            }
        }
    }
}
