using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Newtonsoft.Json;
using static Alarm501ModelController.AlarmModel;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace Alarm501ModelController
{
    public class AlarmController
    {
        AlarmModel model;
        Handler refreshUI;
        Handler disableAddButton;
        AlarmHandler alarmTriggerd;

        // Timer to check if the alarm is going off
        private static System.Timers.Timer alarmCheck = null;

        /*
        // By default, waits 3 seconds before going off again
        // could make a new 'Snooze' object one each different alarm that goes off
        private static System.Windows.Forms.Timer snoozeTimer = new System.Windows.Forms.Timer();
        */

        // List of snoozed alarms
        private static Dictionary<System.Timers.Timer, Alarm> snoozedTimers = new Dictionary<System.Timers.Timer, Alarm>();

        public AlarmController(AlarmModel m)
        {
            model = m;
            alarmCheck = new System.Timers.Timer(1000);
            alarmCheck.Elapsed += new ElapsedEventHandler(TimerEventProcessor);
            alarmCheck.AutoReset = true;
            alarmCheck.Enabled = true;

            LoadAlarms();
        }

        // Register the observers
        public void RegisterObs(Handler o, Handler d, AlarmHandler at)
        {
            refreshUI = o;
            disableAddButton = d;
            alarmTriggerd = at;
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
                            alarmTriggerd(alarm.Index, alarm);
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
            if (sender is System.Timers.Timer timer)
            {
                timer.Stop();

                alarmTriggerd(snoozedTimers[timer].Index, snoozedTimers[timer]);

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

        public void createAlarm(string name, DateTime datetime, bool isOn, AlarmSounds sound, bool isRepeating, List<bool> reaptingDays, int index=-1)
        {

            Alarm alarm = new Alarm(name, datetime, isOn, sound, isRepeating, index, reaptingDays);
            if (index == -1) AddAlarm(alarm);
            else EditAlarm(index, alarm);
        }

        // Add alarm to the list, max 5 alarms
        public void AddAlarm(Alarm alarm)
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
            
            System.Timers.Timer snoozeTimer = new System.Timers.Timer(snoozeTime * 60000);
            
            snoozeTimer.Elapsed += new ElapsedEventHandler(SnoozeEventProcessor);

            snoozeTimer.AutoReset = false;

            snoozeTimer.Enabled = true;

            snoozedTimers.Add(snoozeTimer, alarm);

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
