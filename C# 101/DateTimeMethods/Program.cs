using System;

namespace DateTimeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("{0,-15} {1, 25}","Current Date",currentDate);
            Console.WriteLine("{0,-15} {1, 25}","Time",currentDate.TimeOfDay);
            Console.WriteLine("{0,-15} {1, 25}","Year",currentDate.Year);
            Console.WriteLine("{0,-15} {1, 25}","Month",currentDate.Month);
            Console.WriteLine("{0,-15} {1, 25}","Day",currentDate.Day);
            Console.WriteLine("{0,-15} {1, 25}","Hour",currentDate.Hour);
            Console.WriteLine("{0,-15} {1, 25}","Minute",currentDate.Minute);
            Console.WriteLine("{0,-15} {1, 25}","Second",currentDate.Second);
            Console.WriteLine("{0,-15} {1, 25}","Day of Week",currentDate.DayOfWeek);
            Console.WriteLine("{0,-15} {1, 25}","Day of Year",currentDate.DayOfYear);
        }
    }
}
