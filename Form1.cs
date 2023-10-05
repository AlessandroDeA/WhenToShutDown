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
        private const bool V = true;
        private const bool F = false;
        public int caso;
        private readonly ShutDownService _shutdownService = new ShutDownService();
        public Form_SD()
        {
            InitializeComponent();
        }

        private void Form_SD_Load(object sender, EventArgs e)
        {
            dtPicker.Format = DateTimePickerFormat.Custom;
            dtPicker.CustomFormat = "HH:mm dd/MM/yyyy";
        }

        private void tbMinutes_CheckedChanged(object sender, EventArgs e)
        {
            if (!(tbMinutes.Checked = V))
            {
                boxDate.Enabled = V;
                boxHour.Enabled = V;
                boxTime.Enabled = V;
                _shutdownService.CancelShutdown();
            }
            else
            {
                boxDate.Enabled = F;
                boxHour.Enabled = F;
                boxTime.Enabled = F;
                caso = 1;
            }
        }
        private void tbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (tbTime.Checked)
            {
                boxDate.Enabled = F;
                boxHour.Enabled = F;
                boxMinutes.Enabled = F;
                caso = 2;
            }
            else
            {
                boxDate.Enabled = V;
                boxHour.Enabled = V;
                boxMinutes.Enabled = V;
                _shutdownService.CancelShutdown();
            }
        }

        private void tbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (tbDate.Checked)
            {
                boxHour.Enabled = F;
                boxMinutes.Enabled = F;
                boxTime.Enabled = F;

                caso = 3;
            }
            else 
            {
                boxHour.Enabled = V;
                boxMinutes.Enabled = V;
                boxTime.Enabled = V;
                _shutdownService.CancelShutdown();
            }
        }


        private void tbHours_CheckedChanged(object sender, EventArgs e)
        {
            if (!(tbHours.Checked = V))
            {
                boxMinutes.Enabled = V;
                boxDate.Enabled = V;
                boxTime.Enabled = V;
                _shutdownService.CancelShutdown();
            }
            else
            {
                boxMinutes.Enabled = F;
                boxDate.Enabled = F;
                boxTime.Enabled = F;
                caso = 4;
            }
        }

        private void cBtnArresto_Click(object sender, EventArgs e)
        {
            switch (caso)
            {
                case 1:
                    int minNowAdd = (int)udMinNow.Value;
                    _shutdownService.ExecuteShutdown(minNowAdd);
                    break;
                case 2:
                    int hour = (int)udHrs.Value;
                    int min = (int)udMin.Value;
                    _shutdownService.ScheduleShutdownTime(hour, min);
                    break;
                case 3:
                    DateTime changedDay = dtPicker.Value;
                    _shutdownService.ScheduleShutdownDay(changedDay);
                    break;
                case 4:
                    int hourNowAdd = (int)udHours.Value;
                    _shutdownService.ScheduleShutdownHour(hourNowAdd);
                    break;
            }
        }

        private void cBtnAnnulla_Click(object sender, EventArgs e)
        {
            _shutdownService.CancelShutdown();
        }
    }
}
