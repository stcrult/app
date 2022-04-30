using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            for (int i=1; i<=10; i++) {
                if (i==5) continue;
                if (i==9) break;
                Console.WriteLine(i);
            }
        }
    }
}
