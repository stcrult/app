using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\nArithmetic Operators:");
			      Console.WriteLine("---------------------------------------------");
            Console.WriteLine("{0,-5} {1,-18} {2,5}  {3,5}", "+", "Summation", "2+3", 2+3);
            Console.WriteLine("{0,-5} {1,-18} {2,5}  {3,5}", "-", "Subtraction", "2-3", 2-3);
            Console.WriteLine("{0,-5} {1,-18} {2,5}  {3,5}", "*", "Multiplication", "2*3", 2*3);
            Console.WriteLine("{0,-5} {1,-18} {2,5}  {3,5}", "/", "Division", "2/3", 2/3);
            Console.WriteLine("{0,-5} {1,-18} {2,5}  {3,5}", "%", "Mode", "2%3", 2%3);
            Console.WriteLine("{0,-5} {1,-18} {2,5}", "++", "Increment", "x++");
            Console.WriteLine("{0,-5} {1,-18} {2,5}", "--", "Decrement", "y++");
            Console.WriteLine("\nComparison Operators:");
			      Console.WriteLine("---------------------------------------------");
            Console.WriteLine("{0,-5} {1,-18} {2,5}    {3,-7}", "<", "less than", "2<2", 2<2);
            Console.WriteLine("{0,-5} {1,-18} {2,5}    {3,-7}", "<=", "less or equal", "2<=2", 2<=2);
            Console.WriteLine("{0,-5} {1,-18} {2,5}    {3,-7}", ">", "greater than", "2>2", 2>2);
            Console.WriteLine("{0,-5} {1,-18} {2,5}    {3,-7}", ">=", "greater or equal", "2>=2", 2>=2);
            Console.WriteLine("{0,-5} {1,-18} {2,5}    {3,-7}", "==", "equal", "2==2", 2==2);
            Console.WriteLine("{0,-5} {1,-18} {2,5}    {3,-7}", "!=", "not equal", "2!=2", 2!=2);
            Console.WriteLine("\nLogical Operators:");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("{0,-5} {1,-18}", "&&", "and");
            Console.WriteLine("{0,-5} {1,-18}", "||", "or");
            Console.WriteLine("{0,-5} {1,-18}", "!", "not");
            Console.WriteLine();
            Window myWindow = new Window();
            myWindow.topLine();
            myWindow.content("and","True","False");
            myWindow.middleLine();
            myWindow.content("True","True","False");
            myWindow.middleLine();
            myWindow.content("False","False","False");
            myWindow.bottomLine();
            Console.WriteLine();
            myWindow.topLine();
            myWindow.content(" or","True","False");
            myWindow.middleLine();
            myWindow.content("True","True","True");
            myWindow.middleLine();
            myWindow.content("False","True","False");
            myWindow.bottomLine();
            Console.WriteLine();
            myWindow.topLine();
            myWindow.content("  ","True","False");
            myWindow.middleLine();
            myWindow.content(" not","False","True");
            myWindow.bottomLine();
        }
    }
}
