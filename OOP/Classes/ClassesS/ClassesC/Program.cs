using System;

namespace ClassesC
{
    class Program
    {
        static void Main(string[] args)
        {
            // call to the static methods across the class
            MessageClass.HelloMethod();
        }
    }

    // internal class
    class Message
    {
        public static void HelloMethod()
        {
            Console.WriteLine("Hi, welcome");
        }

        public static void WaitingMethod()
        {
            Console.WriteLine("I'm waiting...");
        }

        public static void ByeMethod()
        {
            Console.WriteLine("Goodbye");
        }
    }
}