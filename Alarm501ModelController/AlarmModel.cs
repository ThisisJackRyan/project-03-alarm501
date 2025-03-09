using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501ModelController
{
    public class AlarmModel
    {

        public static BindingList<Alarm> alarmList = new BindingList<Alarm> { };

        public class Alarm
        {
            // Name of the alarm
            public string AlarmName { get; set; }

            // Time the alarm is set to go off
            public DateTime AlarmTime { get; set; }

            // Whether the alarm is on or off
            public bool IsOn { get; set; }

            public AlarmSounds AlarmSound { get; set; }

            // Whether the alarm is repeating
            public bool IsRepeating { get; set; }

            // Index of the alarm in the list
            public int Index { get; set; }

            // Days the alarm is repeating on
            public List<bool> RepeatingDays = new List<bool>();

            public Alarm(string alarmName, DateTime alarmTime, bool isOn, AlarmSounds alarmSound, bool isRepeating, int index, List<bool> rd)
            {
                this.AlarmName = alarmName;
                this.AlarmTime = alarmTime;
                this.IsOn = isOn;
                this.AlarmSound = alarmSound;
                this.IsRepeating = isRepeating;
                this.Index = index;
                RepeatingDays = rd;


            }

            // Formats string in the correct format to display in the listbox
            public override string ToString()
            {
                string temp = "";

                if(this.AlarmName != "Alarm Name (optional)")
                {
                    temp += this.AlarmName + " - ";
                }

                if (this.AlarmTime.Hour > 12)
                {
                    if (this.AlarmTime.Minute < 10)
                    {
                        temp += this.AlarmTime.Hour - 12 + ":" + "0" + this.AlarmTime.Minute + " PM";
                    }
                    else
                    {
                        temp += this.AlarmTime.Hour - 12 + ":" + this.AlarmTime.Minute + " PM";
                    }
                }
                else
                {
                    if (this.AlarmTime.Minute > 10)
                    {
                        temp += this.AlarmTime.Hour + ":" + this.AlarmTime.Minute;
                    }
                    else
                    {
                        temp += this.AlarmTime.Hour + ":" + this.AlarmTime.Minute;
                    }

                    if (this.AlarmTime.Hour == 12)
                    {
                        temp += " PM";
                    }
                    else
                    {
                        temp += " AM";
                    }
                }

                if (this.IsOn)
                {
                    temp += " On";
                }
                else
                {
                    temp += " Off";
                }

                if(this.IsRepeating)
                {
                    for (int i = 0; i < RepeatingDays.Count; i++)
                    {
                        if (RepeatingDays[i])
                        {
                            temp += " " + Enum.GetName(typeof(DayOfWeek), i).Substring(0, 1);
                        }
                    }
                }

                return temp;
            }
        }
    }
}
