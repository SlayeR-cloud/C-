using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is it today?: ");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("That's true");
                    break;
                case "Tuesday":
                    Console.WriteLine("That's true");
                    break;
                case "Wednesday":
                    Console.WriteLine("That's true");
                    break;
                case "Thursday":
                    Console.WriteLine("That's true");
                    break;
                case "Friday":
                    Console.WriteLine("That's true");
                    break;
                case "Saturday":
                    Console.WriteLine("That's true");
                    break;
                case "Sunday":
                    Console.WriteLine("That's true");
                    break;
                default:
                    Console.WriteLine("That's not a day bro");
                    break;
            }
            Console.ReadKey();
        }
    }
}
