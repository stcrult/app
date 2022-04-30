using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("5 Factorial = " + factorial(5));
        }
        static long factorial(int number) {
            if (number>1) return factorial(number-1) * number;
            else return 1;
        }
    }
}
