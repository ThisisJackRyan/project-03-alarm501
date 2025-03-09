using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alarm501ModelController;

namespace Alarm501
{
    public partial class AlarmGoingOff: Form
    {
        // Index of the alarm in the list
        public int AlarmIndex { get; }

        // Alarm object
        public Alarm Alarm { get; }

        public AlarmHandler turnOffHandler;

        public SnoozeAlarmHandler snoozeAlarmHandler;

        public AlarmGoingOff(int alarmIndex, Alarm alarm, AlarmHandler h, SnoozeAlarmHandler s)
        {
            AlarmIndex = alarmIndex;
            Alarm = alarm;
            snoozeAlarmHandler = s;
            turnOffHandler = h;

            InitializeComponent();

            if (Alarm.AlarmName == "Alarm Name (optional)")
            {
                UxAlarmTime.Text = Alarm.ToString();
            }
            else
            {
                UxAlarmTime.Text = Alarm.AlarmName;
            }

            UxAlarmSound.Text = Alarm.AlarmSound.ToString();
        }

        // Invoke delegate to snooze the alarm
        private void UxSnoozeButton_Click(object sender, EventArgs e)
        {
            snoozeAlarmHandler.Invoke(AlarmIndex, Alarm, (int)UxSnoozeAmount.Value);

            this.Close();
        }

        // Invoke delegate to turn off the alarm
        private void UxTurnOffButton_Click(object sender, EventArgs e)
        {
            turnOffHandler.Invoke(AlarmIndex, Alarm);

            this.Close();
        }
    }
}
