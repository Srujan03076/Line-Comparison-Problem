
using System;

namespace Line_Comparison
{
    class LineComparison
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to Line Comparison Computation");


            //UC_3_compareTwoLines

            double x1, x2, y1, y2;
            double a1, a2, b1, b2;
            Console.WriteLine("Enter co-ordinates of line1");
            Console.WriteLine("Enter co-ordinates (x1, y1): ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter co-ordinates (x2, y2): ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter co-ordinates of line2");
            Console.WriteLine("Enter co-ordinates (a1, b1): ");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter co-ordinates (a2, b2): ");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
            double length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double length2 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));

            if (length1 == length2)
            {
                Console.WriteLine("The Length of two lines is equal.");
            }
            else if (length1 > length2)
            {
                Console.WriteLine("The Length of line 1 is greater than line 2.");
            }
            else if (length1 < length2)
            {
                Console.WriteLine("The Length of line 1 is lesser than line 2.");
            }



        }
    }
}
