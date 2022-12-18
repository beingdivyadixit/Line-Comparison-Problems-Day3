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
            Console.WriteLine("Please Enter X3 & Y3 Co-Ordinates:");
            var X3 = Convert.ToDouble(Console.ReadLine());
            var Y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter X4 & Y4 Co - Ordinates:");
            var X4 = Convert.ToDouble(Console.ReadLine());
            var Y4 = Convert.ToDouble(Console.ReadLine());
            double X = Math.Pow((X2 - X1), 2);
            double Y = Math.Pow((Y2 - Y1), 2);
            double lengthOfFirstLine = Math.Sqrt(X + Y);
            Console.WriteLine("Length Of First Line" + lengthOfFirstLine);
            double x = Math.Pow((X4 - X3), 2);
            double y = Math.Pow((Y4 - Y3), 2);
            double lengthOfSecondLine = Math.Sqrt(x + y);
            Console.WriteLine("Length Of Second Line" + lengthOfSecondLine);
            if (lengthOfFirstLine == lengthOfSecondLine)
            {
                Console.WriteLine("Lines are Equal");
            }
            else
            {
                Console.WriteLine("Lines are not Equal");
            }
        }
    }
}
