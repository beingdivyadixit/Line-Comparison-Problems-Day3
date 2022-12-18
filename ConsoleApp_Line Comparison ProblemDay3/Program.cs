using System;

namespace ConsoleApp_Line_Comparison_ProblemDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison");
            Console.WriteLine("Please Enter X1 & Y1 Co-Ordinates:");
            var X1 = Convert.ToDouble(Console.ReadLine());
            var Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter X2 & Y2 Co - Ordinates:");
            var X2 = Convert.ToDouble(Console.ReadLine());
            var Y2 = Convert.ToDouble(Console.ReadLine());
            double X = Math.Pow((X2 - X1), 2);
            double Y = Math.Pow((Y2 - Y1), 2);
            double lengthOfLine = Math.Sqrt(X + Y);
            Console.WriteLine("Length Of Line is :" + lengthOfLine);
        }
    }
}
