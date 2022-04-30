using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int[] numbers = {2, 2, 1, 42, 3, 9, 2, 30};
            for (int i=0; i<numbers.Length; i++){
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
