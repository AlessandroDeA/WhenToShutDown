using System;
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

        //Arresto pianificato in prossimità di minuti
        public void ExecuteShutdown(int minutesToAdd) 
        {
            ScheduledTime = DateTime.Now.AddMinutes(minutesToAdd);
            if (ScheduledTime.HasValue)
            {
                int secondsToShutdown = (int)(ScheduledTime.Value - DateTime.Now).TotalSeconds;
                if (secondsToShutdown > 0)
                {
                    Process.Start("shutdown", $"/s /t {secondsToShutdown}");
                    MessageBox.Show($"Il computer verrà spento alle ore {ScheduledTime.Value.ToString("HH:mm")}!");
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

        //Arressto pianificiato in giornata (Orario)
        public void ScheduleShutdownTime(int hour, int min) 
        {
            ScheduledTime = DateTime.Today.AddHours(hour).AddMinutes(min);
            DateTime now = DateTime.Now;

            if (ScheduledTime <= now)
            {
                ScheduledTime = DateTime.Today.AddDays(1);
            }
            else 
            {
                MessageBox.Show("Nessun spegnimento è stato programmato!");
            }
            int shutdownTimeInSeconds = (int)(ScheduledTime.Value - now).TotalSeconds;
            Process.Start("shutdown", $"/s /t {shutdownTimeInSeconds}");
            MessageBox.Show($"Il computer si spegnerà alle ore {hour}:{min}");
        }

        //Arresto pianificato in giorni/ore
        public void ScheduleShutdownDay(DateTime dayShutdown) 
        {
            ScheduledTime = dayShutdown;

            if (ScheduledTime.HasValue) 
            {
                DateTime now = DateTime.Now;
                if (ScheduledTime.Value > now)
                {
                    int shutdownDay = (int)(ScheduledTime.Value - now).TotalSeconds;
                    Process.Start("shutdown", $"/s /t {shutdownDay}");
                    MessageBox.Show($"Il computer si spegnerà il {ScheduledTime}");
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


        public void ScheduleShutdownHour(int hour) 
        {
            ScheduledTime = DateTime.Now.AddHours(hour);
            if (ScheduledTime.HasValue) 
            {
                DateTime now = DateTime.Now;
                if (ScheduledTime > now)
                {
                    int shutdownHour = (int)(ScheduledTime.Value - now).TotalSeconds;
                    Process.Start("shutdown", $"/s /t {shutdownHour}");
                    MessageBox.Show($"Il computer si spegnerà alle ore {ScheduledTime.Value.ToString("HH:mm")}");
                }
            }
        }


    }
}
