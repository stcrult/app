using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.Clear();
            try {
                Console.WriteLine(1/x);
                Console.WriteLine("Block that includes the error. This line will not be printed.");
            }catch {
                Console.WriteLine("Error occured.");
            }finally{
                Console.WriteLine("Codes in this block always run.");
            }
        }
    }
}
