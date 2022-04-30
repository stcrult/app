using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            if (2 < 3) Console.WriteLine("2 is less than 3");
            
            if (3 < 2) Console.WriteLine("3 is less than 2");
            else       Console.WriteLine("3 is greater or equal to 2");

            if (3 < 2) Console.WriteLine("3 is less than 2");
            else if (3 == 2) Console.WriteLine("3 is equal to 2");
            else Console.WriteLine("3 greater than 2");
        }
    }
}
