using System;

namespace ExceptionC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exception handling: uses try/catch/finally
            
            // try: try some code that is considered "dangerous"
            // catch: catches and handles exceptions when they occur
            // finally: always executes regardless if exception is caught
            // or not
            
            // for ex. two numbers capture...

            double x;
            double y;
            double result;

            bool exception = true;
            
            while (exception)
            {
                try
                {
                    Console.Write("Enter number 1: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter number 2: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    result = x / y;
                    Console.WriteLine("Result = " + result);
                    exception = false;
                }
                catch (FormatException formatExceptionexception)
                {
                    Console.WriteLine("Enter only numbers");
                }
                catch (DivideByZeroException zeroException)
                {
                    Console.WriteLine("Divide by zero is not allowed");
                }
            }
        }
    }
}