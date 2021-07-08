using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("\tCalculator program");
                Console.WriteLine("---------------------------");
                Console.Write("Enter the 1. number: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the 2. number: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select a option: ");
                Console.WriteLine("\t+: add");
                Console.WriteLine("\t-: subtract");
                Console.WriteLine("\t*: multiply");
                Console.WriteLine("\t/: divide");
                Console.Write("Option: ");
                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($"ADD of {number1} + {number2} equal to = " + (number1 + number2));
                        break;
                    case "-":
                        Console.WriteLine($"SUBTRACT of {number1} - {number2} equal to = " + (number1 - number2));
                        break;
                    case "*":
                        Console.WriteLine($"MULTIPLY of {number1} * {number2} equal to = " + (number1 * number2));
                        break;
                    case "/":
                        Console.WriteLine($"DIVIDE of {number1} / {number2} equal to = " + (number1 / number2));
                        break;
                    default:
                        Console.WriteLine("NOT VALID OPTION");
                        break;
                }
                Console.Write("Continue using? y/n: ");
                String answer = Console.ReadLine();
                answer = answer.ToLower();
                if (answer != "y")
                {
                    again = false;
                }
            }
        }
    }
}