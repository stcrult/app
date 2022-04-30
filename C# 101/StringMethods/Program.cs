using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World!";
            Console.Clear();
            Console.WriteLine("{0,-15}: {1}", "String", s);
            Console.WriteLine("{0,-15}: {1}", "Length", s.Length);
            Console.WriteLine("{0,-15}: {1}", "Upper", s.ToUpper());
            Console.WriteLine("{0,-15}: {1}", "Lower", s.ToLower());
            Console.WriteLine("{0,-15}: {1}", "Compare", string.Compare(s, "Hello", true));
            Console.WriteLine("{0,-15}: {1}", "String", s.Contains("Hello"));
            Console.WriteLine("{0,-15}: {1}", "String", s.Contains("Bello"));
            Console.WriteLine("{0,-15}: {1}", "String", s.PadLeft(20));
            Console.WriteLine("{0,-15}: {1}", "String", s.PadRight(20,'*'));
        }
    }
}
