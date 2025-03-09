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

namespace Alarm501
{
    public partial class Alarm501 : Form
    {

        AlarmModel model;
        private Handler handlerAddAlarm;
        private Handler handlerFormClose;
        private EditAlarmHandler handlerEditAlarm;

        // List of alarms, binding list to update the UI
        //public static BindingList<AlarmModel> alarmList = new BindingList<AlarmModel> { };

        public Alarm501(AlarmModel am, Handler aa, Handler fc, EditAlarmHandler ea)
        {
            InitializeComponent();

            UxAlarmList.DataSource = AlarmModel.alarmList;

            UxActiveAlarms.DataSource = AlarmModel.alarmList.Where(alarm => alarm.IsOn).ToList();

            this.FormClosing += Alarm501_FormClosing;

            model = am;

            handlerFormClose = fc;
            handlerEditAlarm = ea;
            handlerAddAlarm = aa;

            if(AlarmModel.alarmList.Count >= 5)
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
            handlerAddAlarm.Invoke();
        }

        // Edit alarm button click event
        private void UxEditBtn_Click(object sender, EventArgs e)
        {
            handlerEditAlarm.Invoke(UxAlarmList.SelectedIndex);
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
