using System;

namespace WhileForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int i=0;
            while (i<=10) {
                i++;
                if (i==5) continue;
                if (i==9) break;
                Console.WriteLine(i);              
            }

            int[] numbers = {1,3,5,7};
            foreach (int number in numbers) {
                Console.WriteLine(number);
            }
        }
    }
}
