using System;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // to round up and round down there is the 

            // round up: Ceiling() function
            // round down: Floor() function

            // round certain decimal number: use Round(value, decimalNumber) 

            // then if we want the absolute value of a number use Math.Abs(value)

            // for pow a value, use Math.Pow(value, pow)

            // Math.Max(x,y) returns the large value between two numbers

            // then it is the Math.Sqrt(value) function, returns the square root of a value.

            double x = 3.989892323;
            double new_x = Math.Round(x, 2);
            double power_x = Math.Pow(x, 2);
            int newx = 10;
            int newy = 50;
            int largest = Math.Max(newx, newy);
            double square_root = Math.Sqrt(x);
            Console.WriteLine(new_x);
            Console.WriteLine(power_x);
            Console.WriteLine(largest);
            Console.WriteLine(square_root);
            Console.ReadLine();
        }
    }
}
