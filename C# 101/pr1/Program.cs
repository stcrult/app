using System;

namespace pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Clear();
            Console.Write("Enter n =? ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i=1; i<=n; i++) {
                Console.Write("Enter number"+i+" =? ");
                numbers[i-1]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Even numbers :");
            for (int i=0; i<n; i++) {
                if (numbers[i] % 2 ==0) Console.Write(numbers[i]+" ");
            }
            Console.WriteLine("\n");
            Console.Write("Enter n =? ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter m =? ");
            m = Convert.ToInt32(Console.ReadLine());
            numbers = new int[n];
            for (int i=1; i<=n; i++) {
                Console.Write("Enter number"+i+" =? ");
                numbers[i-1]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("numbers divisible by "+m+" :");
            for (int i=0; i<n; i++) {
                if (numbers[i] % m ==0) Console.Write(numbers[i]+" ");
            }
            Console.WriteLine("\n");
        }
    }
}
