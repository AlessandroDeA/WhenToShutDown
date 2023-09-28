﻿using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhenToShutDown
{
    public class ShutDownService
    {
        public DateTime? ScheduledTime { get; private set; }

        //Pianificazione per minuti in più dell'arresto del pc
        public void ScheduleShutdown(int minutesToAdd) 
        {
            ScheduledTime = DateTime.Now.AddMinutes(minutesToAdd);
            MessageBox.Show($"Il computer verrà spento tra {minutesToAdd}, premere 'Pianifica arresto '");
        }

        //Annullamento dell'arresto pianificato
        public void CancelShutdown() 
        {
            if (ScheduledTime != null)
            {
                Process.Start("shutdown", "/a");
                ScheduledTime = null;
                MessageBox.Show("Operazione di spegnimento PC pianificata annullata!");
            }
            else 
            {
                MessageBox.Show("Nessun spegnimento è stato programmato!");
            }
        }

        public void ExecuteShutdown() 
        {
            if (ScheduledTime.HasValue)
            {
                int secondsToShutdown = (int)(ScheduledTime.Value - DateTime.Now).TotalSeconds;
                if (secondsToShutdown > 0)
                {
                    Process.Start("shutdown", $"/s /t{secondsToShutdown}");
                }
                else
                {
                    MessageBox.Show("Il tempo programmato per lo spegnimento è già passato!");
                }
            }
            else 
            {
                MessageBox.Show("Nessun spegnimento è stato programmato!");
            }
        }

        public void ScheduleShutdownTime(int hour, int min) 
        {
            ScheduledTime = DateTime.Today.AddHours(hour).AddMinutes(min);
            if (ScheduledTime.HasValue)
            {
                DateTime now = DateTime.Now;

                if (ScheduledTime.Value > now)
                {
                    int shutDownTime = (int)(ScheduledTime.Value - now).TotalSeconds;
                    Process.Start("shutdown", $"/s /t{shutDownTime}");
                    MessageBox.Show($"Il computer si spegnerà alle ore {hour}:{min}");
                }
                else
                {
                    MessageBox.Show("Il tempo programmato per lo spegnimento è già passato!");
                }
            }
            else 
            {
                MessageBox.Show("Nessun spegnimento è stato programmato!");
            }
        }
        public void ScheduleShutdownDay(DateTime dayShutdown) 
        {
            ScheduledTime = dayShutdown;

            if (ScheduledTime.HasValue) 
            {
                DateTime now = DateTime.Now;
                if (ScheduledTime.Value > now)
                {
                    int shutDownDay = (int)(ScheduledTime.Value - now).TotalSeconds;
                    Process.Start("shutdown", $"/s /t {shutDownDay}");
                    MessageBox.Show($"Il computer si spegnerà tra {ScheduledTime}");
                }
                else 
                {
                    MessageBox.Show("Il tempo programmato per lo spegnimento è già passato!");
                }
            }
            else
            {
                MessageBox.Show("Nessun spegnimento è stato programmato!");
            }
        }
    }
}