using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> Weekdays = new CustomList<string>();
            Weekdays.Add("Monday");
            Weekdays.Add("Tuesday");
            Weekdays.Add("Wednesday");
            Weekdays.Add("Thursday");
            Weekdays.Add("Friday");
        }
            
    }
}
