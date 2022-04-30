using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {3, 1, 9, 7, 3, 2};
            Console.Clear();
            Console.WriteLine(string.Join(" ", numbers));
            Array.Reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers));
            Array.Sort(numbers);
            Console.WriteLine(string.Join(" ", numbers));
            Array.Clear(numbers,3,2);
            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine(Array.IndexOf(numbers,9));
        }
    }
}
