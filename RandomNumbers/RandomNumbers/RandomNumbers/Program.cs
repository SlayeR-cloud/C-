using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // for generate random numbers, we need a random object

            Random random = new Random();

            random.Next(); // random integer, pass it a range (1, 7) the 7 is omitted
            Console.WriteLine(random.Next(1,100));
            // also can use random.NextDouble() method for float numbers just
            // between 0 and 1

            // you can use ex: random.NextDouble() + 10, for generate a double number
            // between 10 and 11

            Console.WriteLine(random.NextDouble());
            Console.ReadLine();
        }
    }
}
