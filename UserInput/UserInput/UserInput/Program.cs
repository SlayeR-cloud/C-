using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the Console.ReadLine() method for take the user input until he press enter key
            Console.Write("Please write your name: ");
            // Console.ReadLine() method always returns a string value, its neccesary to convert it
            // if we want to have another type of variables
            string name = Console.ReadLine();
            Console.Write("Please put your age: ");
            int age = Convert.ToInt32(Console.ReadLine()); // this will convert string to int
            // remind that exist a long int and int normal, int uses 32 bits of space
            // and long uses 64, so for that Convert.ToInt32 method is like that
            Console.Write("Please put the temp outside C°: ");
            double temp = Convert.ToDouble(Console.ReadLine()); // this will convert string to double
            Console.Write("What's your favorite symbol?: ");
            char character = Convert.ToChar(Console.ReadLine());
            Console.Write("Are you alive? true/false: ");
            bool alive = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Hi " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Temp: " + temp + "C°");
            Console.WriteLine("Fav. Symbol: " + character);
            Console.WriteLine("Alive status: " + alive);
            Console.ReadLine();
        }
    }
}
