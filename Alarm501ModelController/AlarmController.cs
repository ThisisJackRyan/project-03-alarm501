using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Newtonsoft.Json;
using static Alarm501.AlarmModel;
using System.IO;

namespace Alarm501ModelController
{
    public class AlarmController
    {
        AlarmModel model;
        Handler refreshUI;
        Handler disableAddButton;

        // Timer to check if the alarm is going off
        private static System.Windows.Forms.Timer alarmCheck = new System.Windows.Forms.Timer();

        /*
        // By default, waits 3 seconds before going off again
        // could make a new 'Snooze' object one each different alarm that goes off
        private static System.Windows.Forms.Timer snoozeTimer = new System.Windows.Forms.Timer();
        */

        // List of snoozed alarms
        private static Dictionary<System.Windows.Forms.Timer, Alarm> snoozedTimers = new Dictionary<System.Windows.Forms.Timer, Alarm>();

        public AlarmController(AlarmModel m)
        {
            model = m;

            alarmCheck.Tick += new EventHandler(TimerEventProcessor);

            alarmCheck.Interval = 980; // timer runs slightly faster than a second to make sure it catches the alarm on slower hardware
            alarmCheck.Start();

            LoadAlarms();
        }

        // Register the observers
        public void RegisterObs(Handler o, Handler d)
        {
            refreshUI = o;
            disableAddButton = d;
        }

        // Running timer in the background to check if the alarm is going off
        // maybe need static
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            alarmCheck.Stop();

            foreach (Alarm alarm in alarmList)
            {
                if (alarm.IsOn)
                {
                    if (alarm.RepeatingDays[(int)DateTime.Now.DayOfWeek] || !alarm.IsRepeating)
                    {
                        if (alarm.AlarmTime.Hour == DateTime.Now.Hour && alarm.AlarmTime.Minute == DateTime.Now.Minute && alarm.AlarmTime.Second == DateTime.Now.Second)
                        {
                            AlarmGoingOff alarmGoingOff = new AlarmGoingOff(alarm.Index, alarm, OnStop, OnSnooze);
                            alarmGoingOff.ShowDialog();
                        }
                    }
                }
            }

            alarmCheck.Enabled = true;
        }

        // Snooze timer event processor
        // maybe need static
        private void SnoozeEventProcessor(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.Timer timer)
            {
                timer.Stop();

                AlarmGoingOff alarmGoingOff = new AlarmGoingOff(snoozedTimers[timer].Index, snoozedTimers[timer], OnStop, OnSnooze);
                alarmGoingOff.ShowDialog();

                snoozedTimers.Remove(timer);
            }
        }

        // Load alarms from the file
        private void LoadAlarms()
        {
            if (File.Exists("alarms.txt"))
            {
                string[] lines = File.ReadAllLines("alarms.txt");

                foreach (string line in lines)
                {
                    Alarm alarm = JsonConvert.DeserializeObject<Alarm>(line); ;
                    if (alarm != null)
                    {
                        alarmList.Add(alarm);
                    }
                }
            }
        }

        // Save alarms to the file
        public void FormClosing()
        {
            if (alarmList != null && alarmList.Count > 0)
            {
                List<string> alarmJsonList = new List<string>();
                foreach (Alarm alarm in alarmList)
                {
                    string alarmJson = JsonConvert.SerializeObject(alarm);
                    alarmJsonList.Add(alarmJson);
                }
                File.WriteAllLines("alarms.txt", alarmJsonList);
            }
        }

        #region AddEditAlarm controls

        // Make a new AddEditAlarm form
        public void AddAlarmDialouge()
        {
            AddEditAlarm addEditAlarm = new AddEditAlarm(AddAlarm);
            addEditAlarm.ShowDialog();
        }

        // Make a new AddEditAlarm form with the alarm to edit
        public void EditAlarmDialouge(int alarmIndex)
        {
            Alarm temp = alarmList[alarmIndex];

            AddEditAlarm addEditAlarm = new AddEditAlarm(temp.AlarmTime, temp.IsOn, temp.AlarmSound, temp.IsRepeating, temp.RepeatingDays, temp.AlarmName, temp.Index, EditAlarm);
            addEditAlarm.ShowDialog();
        }

        // Add alarm to the list, max 5 alarms
        public void AddAlarm(int index, Alarm alarm)
        {
            alarm.Index = alarmList.Count;

            alarmList.Add(alarm);

            refreshUI();

            if (alarmList.Count >= 5) disableAddButton();
        }

        // Edit alarm in the list
        public void EditAlarm(int index, Alarm alarm)
        {
            // will need to abstract this out, in controller
            alarmList[index] = alarm;
            refreshUI();
        }

        #endregion

        #region AlarmGoingOff controls

        // Snooze the alarm, add a new snooze timer to the list
        public void OnSnooze(int index, Alarm alarm, int snoozeTime)
        {
            System.Windows.Forms.Timer snoozeTimer = new System.Windows.Forms.Timer();

            snoozeTimer.Tick += SnoozeEventProcessor;

            snoozeTimer.Interval = snoozeTime * 60000;

            snoozedTimers.Add(snoozeTimer, alarm);

            snoozeTimer.Start();
        }

        // Stop the alarm, if it is not repeating, turn it off
        public void OnStop(int index, Alarm alarm)
        {
            if(!alarm.IsRepeating)
            {
                alarm.IsOn = false;
                refreshUI();
            }
        }

        #endregion
    }
}
