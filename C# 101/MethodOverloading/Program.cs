using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(sumOfNumbers(1));
            Console.WriteLine(sumOfNumbers(1, 2));
            Console.WriteLine(sumOfNumbers(1, 2, 3));
            Console.WriteLine(sumOfNumbers(new int[] {1,2,3,4,5}));
        }

        static int sumOfNumbers(int a) {
            return a;
        }        static int sumOfNumbers(int a, int b) {
            return a + b;
        }
        static int sumOfNumbers(int a, int b, int c) {
            return a + b + c;
        }

        static int sumOfNumbers(int[] arr) {
            int sum = 0;
            for (int i=0; i<arr.Length; i++) {
                sum+=arr[i];
            }
            return sum;
        }
    }
}
