using System;

namespace ConsoleApp_Line_Comparison_ProblemDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            // user input for first line
            Console.WriteLine("Enter x1 and y2 of first line");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 and x2 of first line");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());
            double length1= length(x1, y1, x2, y2);

            // user input for second line
            Console.WriteLine("Enter x1 and y2 of second line");
            var x3 = Convert.ToDouble(Console.ReadLine());
            var y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 and x2 of second line");
            var x4 = Convert.ToDouble(Console.ReadLine());
            var y4 = Convert.ToDouble(Console.ReadLine());
            double length2 =length(x3, y3, x4, y4); 

            // Using Compare Method For comparing both line
            int status = (length1.CompareTo(length2));
            if (status > 0)
                Console.WriteLine(" Length of first line : {0} is greater then Length of second line : {1}", length1, length2);
            else if (status < 0)
                Console.WriteLine(" Length of first line : {0} is less then Length of second line : {1}", length1, length2);
            else
                Console.WriteLine(" Length of first line : {0} is equal to Length of second line : {1}", length1, length2);

        }
          // creating  method to caculate the length
        public static double length(double X, double Y, double X1, double Y1)
        {
            double L1 = Math.Pow((X - Y), 2);
            double L2 = Math.Pow((X1 - Y1), 2);
            double LengthOfLine = Math.Sqrt(L1 + L2);
            return LengthOfLine;

        }
    }
}
