using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alarm501ModelController;


namespace Alarm501Console
{
    class Program
    {
        static void Main(string[] args)
        {
            AlarmConsole c = new AlarmConsole();
            c.DisplayAlarms();
        }
    }
}
