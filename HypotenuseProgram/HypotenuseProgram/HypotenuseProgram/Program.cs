using System;

namespace HypotenuseProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
            Console.WriteLine("The hypotenuse is: " + c);
            Console.ReadKey();
        }
    }
}
