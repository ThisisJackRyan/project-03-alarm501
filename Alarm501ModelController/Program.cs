using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Alarm501ModelController.AlarmModel;

namespace Alarm501ModelController
{
    public delegate void Handler();
    public delegate void EditAlarmHandler(int alarmIndex);
    public delegate void CreateAlarm(string name, DateTime datetime, bool isOn, AlarmSounds sound, bool isRepeating, List<bool> reaptingDays, int index=-1);
    public delegate void AlarmHandler(int alarmIndex, Alarm alarm);
    public delegate void SnoozeAlarmHandler(int alarmIndex, Alarm alarm, int snoozeTime);

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
