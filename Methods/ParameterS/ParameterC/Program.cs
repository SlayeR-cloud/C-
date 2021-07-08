using System;

namespace ParameterC
{
    class Program
    {
        static void Main(string[] args)
        {
            // params keyword: a method parameter that takes a variable number of arguments 
            // the parameter type must be a single -> dimensional array
            double list = Total(3.99, 1.45, 1.98);
            Console.WriteLine(list);
            Console.ReadKey();
        }
        static double Total(params double[] prices)
        {
            double total = 0;
            foreach (double price in prices)
            {
                total += price;
            }
            return total;
        }
    }
}