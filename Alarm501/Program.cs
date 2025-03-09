using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Alarm501.AlarmModel;

namespace Alarm501
{
    public delegate void Handler();
    public delegate void EditAlarmHandler(int alarmIndex);
    public delegate void AlarmHandler(int alarmIndex, Alarm alarm);
    public delegate void SnoozeAlarmHandler(int alarmIndex, Alarm alarm, int snoozeTime);

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
            Alarm501 view = new Alarm501(am, ac.AddAlarmDialouge, ac.FormClosing, ac.EditAlarmDialouge);

            ac.RegisterObs(view.RefreshUI, view.DisableAddButton);

            Application.Run(view);
        }
    }
}
