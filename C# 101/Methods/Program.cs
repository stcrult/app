using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(sumOfTwoNumbers(2, 3));
        }

        static int sumOfTwoNumbers(int a, int b) {
            return a+b;
        }
    }
}
