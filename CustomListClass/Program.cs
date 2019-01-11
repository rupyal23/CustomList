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

            //In Built List
            List<string> Weekdays = new List<string>();
            Weekdays.Add("Monday");
            Weekdays.Add("Tuesday");
            Weekdays.Add("Wednesday");
            Weekdays.Add("Thursday");
            Weekdays.Add("Friday");


            //My Custom List
            CustomList<string> customWeekdays = new CustomList<string>();
            customWeekdays.Add("Monday");
            customWeekdays.Add("Tuesday");
            customWeekdays.Add("Saturday");
            customWeekdays.Add("Wednesday");
            customWeekdays.Add("Thursday");
            customWeekdays.Add("Friday");
            customWeekdays.Add("Saturday");
            customWeekdays.Add("Sunday");
            customWeekdays.Add("Monday");
            var sb = new StringBuilder();
            sb.AppendLine(customWeekdays[0]);
            sb.AppendLine(customWeekdays[1]);
            sb.AppendLine(customWeekdays[2]);
            sb.AppendLine(customWeekdays[3]);
            sb.AppendLine(customWeekdays[4]);
            sb.AppendLine(customWeekdays[5]);
            sb.AppendLine(customWeekdays[6]);
            sb.AppendLine(customWeekdays[7]);
            sb.AppendLine(customWeekdays[8]);
            //proves that count is read only property
            //customWeekdays.count = 8;
            Console.WriteLine(sb);
            Console.WriteLine($"Custom List count is {customWeekdays.count}");
            

            Console.WriteLine("Press Enter to remove Saturday from the List");
            Console.ReadLine();
            customWeekdays.Remove("Saturday");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
