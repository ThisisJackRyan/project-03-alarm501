using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alarm501ModelController;

namespace Alarm501
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AlarmModel am = new AlarmModel();
            AlarmController ac = new AlarmController(am);
            Alarm501 view = new Alarm501(am, ac.FormClosing, ac.createAlarm, ac.OnStop, ac.OnSnooze);

            ac.RegisterObs(view.RefreshUI, view.DisableAddButton, view.AlarmTriggered);

            Application.Run(view);
        }
    }
}
