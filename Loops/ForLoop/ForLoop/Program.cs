using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // same as java

            for (int i = 1; i <= 10; i++) // can be also i+=1
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
