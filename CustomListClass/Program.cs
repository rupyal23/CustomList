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
            customWeekdays.Add("Thursday");
            customWeekdays.Add("Friday");
            customWeekdays.Add("Saturday");
            customWeekdays.Add("Sunday");
            
            var sb = new StringBuilder();
            sb.AppendLine(customWeekdays[0]);
            sb.AppendLine(customWeekdays[1]);
            sb.AppendLine(customWeekdays[2]);
            sb.AppendLine(customWeekdays[3]);
            sb.AppendLine(customWeekdays[4]);
            sb.AppendLine(customWeekdays[5]);
            sb.AppendLine(customWeekdays[6]);
            
            //proves that count is read only property
            //customWeekdays.count = 8;
            Console.WriteLine(sb);
            Console.WriteLine($"Custom List count is {customWeekdays.count}");
            

            Console.WriteLine("Press Enter to remove Saturday from the List");
            Console.ReadLine();
            customWeekdays.Remove("Saturday");
            sb.Clear();
            sb.AppendLine(customWeekdays[0]);
            sb.AppendLine(customWeekdays[1]);
            sb.AppendLine(customWeekdays[2]);
            sb.AppendLine(customWeekdays[3]);
            sb.AppendLine(customWeekdays[4]);
            sb.AppendLine(customWeekdays[5]);
            sb.AppendLine(customWeekdays[6]);
            Console.WriteLine(sb);
            
            Console.ReadLine();
            Console.WriteLine("Press Enter to Add wednesday");
            Console.ReadLine();
            customWeekdays.Add("Wednesday", 2);
            var sb1 = new StringBuilder();
            sb1.AppendLine(customWeekdays[0]);
            sb1.AppendLine(customWeekdays[1]);
            sb1.AppendLine(customWeekdays[2]);
            sb1.AppendLine(customWeekdays[3]);
            sb1.AppendLine(customWeekdays[4]);
            sb1.AppendLine(customWeekdays[5]);
            sb1.AppendLine(customWeekdays[6]);

            Console.WriteLine(sb1);
            Console.ReadLine();

        }
    }
}
