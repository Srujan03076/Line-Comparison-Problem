using System;

namespace Line_Comparison
{
    class LineComparison
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to Line Comparison Computation");

            //UC_1_singleLineLength
            double x1, x2, y1, y2;
            Console.WriteLine("Enter co-ordinates (x1, y1): ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter co-ordinates (x2, y2): ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The Length of the line is: " + length);
        }
    }
}