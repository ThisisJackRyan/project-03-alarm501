using Alarm501ModelController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501Console
{
	public class AlarmConsole
	{
		private Dictionary<uint, AlarmModel.Alarm> _alarmSelectionMap;

		public void DisplayAlarmsConsole()
		{
			Console.Clear();
			LoadSelectionMap();
			PrintAlarms();
			StartDialogue();
		}

		private void LoadSelectionMap()
		{
			uint alarmsCounter = 0;
			foreach (AlarmModel.Alarm a in AlarmModel.alarmList)
			{
				alarmsCounter += 1;
				_alarmSelectionMap.Add(alarmsCounter, a);

			}
		}

		private void PrintAlarms()
		{
			Console.WriteLine("All Alarms: ");
			foreach(uint key in _alarmSelectionMap.Keys)
			{
				Console.WriteLine("(" + key + ") " + _alarmSelectionMap[key].ToString());
			}

			Console.WriteLine("Active Alarms: ");
			foreach (AlarmModel.Alarm a in AlarmModel.alarmList.Where(alarm => alarm.IsOn).ToList())
			{
				Console.WriteLine(a.ToString());
			}
		}

		private void StartDialogue()
		{
			Console.WriteLine("----------------------------------");
			Console.WriteLine("(1) Add an alarm");
			Console.WriteLine("(2) Edit an alarm");
			Console.WriteLine("(3) Delete an alarm");
			Console.WriteLine("----------------------------------");

			bool cont = true;
			while (cont)
			{
				Console.Write("Enter your choice: ");
				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						cont = false;
						AddAlarm();
						break;
					case "2":
						cont = false;
						EditAlarm();
						break;
					case "3":
						cont = false;
						DeleteAlarm();
						break;
					default:
						Console.WriteLine("Invalid choice");
						break;
				}
			}
		}

		private void AddAlarm()
		{
			// Code to add an alarm
		}

		private void EditAlarm()
		{
			// Code to edit an alarm
		}

		private void DeleteAlarm()
		{
			// Code to delete an alarm
		}
	}
}
