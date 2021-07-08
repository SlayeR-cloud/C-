using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 100;

            // there are a usefull functions like String.IsNullOrEmpty(stringvalue)
            // can use ! to evaluate if a condition is not true ex: !String.IsNullOrEmpty(stringvalue)

            if (age>=21 && age<=100)
            {
                Console.WriteLine("You're equal or higher than 40 years old");
            }
            else if (age>12)
            {
                Console.WriteLine("You're higher than 12 years old");
            }
            else
            {
                Console.WriteLine("You're less than 40 years old");
            }
            Console.ReadLine();
        }
    }
}
