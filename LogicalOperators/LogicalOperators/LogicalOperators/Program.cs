using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logical Operators, same as java 

            // && -> and
            // || -> or

            Console.WriteLine("Enter the life average of a person: ");
            int average = Convert.ToInt32(Console.ReadLine());

            if (average >= 0 && average <= 100)
            {
                Console.WriteLine("Correct!");
            }
            else if (average < 0 || average > 100)
            {
                Console.WriteLine("Not Correct!");
            }

            Console.ReadKey();
        }
    }
}
