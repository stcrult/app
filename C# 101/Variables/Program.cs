using System;

namespace C__101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VALUE TYPE:");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Integers:");
            Console.WriteLine("{0,-10} {1,-15}\t{2,30}\t{3,30}", "byte", typeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0,-10} {1,-15}\t{2,30}\t{3,30}", "sbyte", typeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("{0,-10} {1,-15}\t{2,30}\t{3,30}", "short", typeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine("{0,-10} {1,-15}\t{2,30}\t{3,30}", "ushort", typeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("{0,-10} {1,-15}\t{2,30}\t{3,30}", "int", typeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine("{0,-10} {1,-15}\t{2,30}\t{3,30}", "unit", typeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine("{0,-10} {1,-15}\t{2,30}\t{3,30}", "long", typeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine("{0,-10} {1,-15}\t{2,30}\t{3,30}", "ulong", typeof(ulong), ulong.MinValue, ulong.MaxValue);

            Console.WriteLine("\nFloating Point:");
            Console.WriteLine("{0,-10} {1,-15}\t{2,30}\t{3,30}", "float", typeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine("{0,-10} {1,-15}\t{2,30}\t{3,30}", "double", typeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine("{0,-10} {1,-15}\t{2,30}\t{3,30}", "decimal", typeof(decimal), decimal.MinValue, decimal.MaxValue);

            Console.WriteLine("\nText:");
            Console.WriteLine("{0,-10} {1}", "char", typeof(char));

            Console.WriteLine("\nBoolean:");
            Console.WriteLine("{0,-10} {1,-15} {2,-5} {3, -5}", "bool", typeof(bool), true, false);

            Console.WriteLine("\nREFERENCE TYPE:");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("{0,-10} {1,-15}", "string", typeof(string));
            object o = 12.34;
            Console.WriteLine("{0,-10} {1,-15}", "object", typeof(object));
            int[] q = { 12, 45, 56 };
            Console.WriteLine("int[]\tq = {0}",typeof(int[]));
        }
    }
}
