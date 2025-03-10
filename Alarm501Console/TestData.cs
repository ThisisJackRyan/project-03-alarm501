using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alarm501ModelController;

namespace Alarm501Console
{
	public static class TestData
	{
		public static List<AlarmModel.Alarm> _alarmsList = new List<AlarmModel.Alarm>();

		public static void InitializeTestData()
		{
			List<bool> rDays = new List<bool>() { true, false, true, false, false, false, false };

			// Active Alarms

			AlarmModel.Alarm a1 = new AlarmModel.Alarm(
				string.Empty, DateTime.Now.AddHours(1), true, AlarmSounds.Radar, true, 0, rDays
			);

			AlarmModel.Alarm a2 = new AlarmModel.Alarm(
				"Active Two", DateTime.Now.AddMinutes(1), true, AlarmSounds.Chimes, true, 0, rDays
			);

			AlarmModel.Alarm a3 = new AlarmModel.Alarm(
				"An Alarm", DateTime.Now.AddMinutes(1), true, AlarmSounds.Reflection, false, 0, new List<bool>()
			);

			// Inactive Alarms

			AlarmModel.Alarm a4 = new AlarmModel.Alarm(
				string.Empty, DateTime.Now.AddMinutes(1), false, AlarmSounds.Chimes, true, 0, rDays
			);

			AlarmModel.Alarm a5 = new AlarmModel.Alarm(
				"Inactive Two", DateTime.Now.AddMinutes(1), false, AlarmSounds.Chimes, true, 0, new List<bool>()
			);

			_alarmsList.Add(a1);
			_alarmsList.Add(a2);
			_alarmsList.Add(a3);
			_alarmsList.Add(a4);
			_alarmsList.Add(a5);
		}
	}
}
