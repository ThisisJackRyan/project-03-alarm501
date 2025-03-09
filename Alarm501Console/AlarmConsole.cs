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
        public void StartDialogue()
        {

        }

        public void DisplayAlarms()
        {
            Console.Clear();
            foreach(Alarm501ModelController.AlarmModel.Alarm a in Alarm501ModelController.AlarmModel.alarmList)
            {
                Console.WriteLine(a.ToString() + "\n");
            }
        }

        /*
         * 1. Display the alarms any time a new event occurs, below show all the possible options for input
         * 2. Have a method interpret the users input, after interpretation send the correct delegate to the console for handling
         * 3. Dialogue based, let the user build an alarm step by step, store there configurations in instance variables, exception handling necessary
         */
    }
}
