using System;

namespace WhileForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int i=1;
            while (i<=10) {
                if (i==5) continue;
                if (i==9) break;
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
