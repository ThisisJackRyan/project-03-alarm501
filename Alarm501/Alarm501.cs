using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Alarm501ModelController;
using static Alarm501ModelController.AlarmModel;


namespace Alarm501
{
    public partial class Alarm501 : Form
    {

        AlarmModel model;
        private Handler handlerFormClose;
        private AlarmHandler addAlarm;
        private CreateAlarm createAlarm;
        private AlarmHandler onStop;
        private SnoozeAlarmHandler onSnooze;

        // List of alarms, binding list to update the UI
        //public static BindingList<AlarmModel> alarmList = new BindingList<AlarmModel> { };

        public Alarm501(AlarmModel am, Handler fc, CreateAlarm ca, AlarmHandler ost, SnoozeAlarmHandler osn)
        {
            InitializeComponent();

            UxAlarmList.DataSource = AlarmModel.alarmList;

            UxActiveAlarms.DataSource = AlarmModel.alarmList.Where(alarm => alarm.IsOn).ToList();

            this.FormClosing += Alarm501_FormClosing;

            model = am;

            handlerFormClose = fc;
            createAlarm = ca;
            onStop = ost;
            onSnooze = osn;

            if (AlarmModel.alarmList.Count >= 5)
            {
                DisableAddButton();
            }
        }

        // Refreshes the UI
        public void RefreshUI()
        {
            UxAlarmList.DataSource = null;
            UxAlarmList.DataSource = AlarmModel.alarmList;

            UxActiveAlarms.DataSource = null;
            UxActiveAlarms.DataSource = AlarmModel.alarmList.Where(alarm => alarm.IsOn).ToList();
        }

        // Disables the add alarm button
        public void DisableAddButton()
        {
            UxAddBtn.Enabled = false;
        }

        // Add alarm button click event
        private void UxAddBtn_Click(object sender, EventArgs e)
        {
            AddEditAlarm addEditAlarm = new AddEditAlarm(createAlarm);
            addEditAlarm.ShowDialog();
        }

        public void AlarmTriggered(int index, Alarm alarm)
        {
            AlarmGoingOff alarmGoingOff = new AlarmGoingOff(index, alarm, onStop, onSnooze);
            alarmGoingOff.ShowDialog();
        }

        // Edit alarm button click event
        private void UxEditBtn_Click(object sender, EventArgs e)
        {
            //handlerEditAlarm.Invoke(UxAlarmList.SelectedIndex);
            AddEditAlarm addEditAlarm = new AddEditAlarm(createAlarm, UxAlarmList.SelectedIndex);
            addEditAlarm.ShowDialog();
        }

        // Saves the alarms to a file when the form is closing
        private void Alarm501_FormClosing(object sender, FormClosingEventArgs e)
        {
            handlerFormClose.Invoke();
        }

        // Changes state of the edit button depending on if an alarm is selected
        private void UxAlarmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(UxAlarmList.SelectedIndex != -1)
            {
                UxEditBtn.Enabled = true;
            }
            else
            {
                UxEditBtn.Enabled = false;
            }
        }
    }
}
