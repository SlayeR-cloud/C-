using System;

namespace MethodP
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            Console.Write("Add the phrase you want to repeat: ");
            String phrase = Console.ReadLine();
            Console.Write("How much times?: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("RECURSIVE");
            watch.Start();
            repeatPhrase2(phrase, number);
            watch.Stop();
            double time = watch.ElapsedMilliseconds;
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            // .....
            Console.WriteLine("FOR LOOP");
            watch.Start();
            repeatPhrase(phrase, number);
            watch.Stop();
            double time2 = watch.ElapsedMilliseconds;
            
            Console.WriteLine("RECURSIVE");
            Console.WriteLine($"Execution Time: {time} ms");
            Console.WriteLine("FOR LOOP");
            Console.WriteLine($"Execution Time: {time2} ms");
        }

        static void repeatPhrase(String phrase, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(phrase);
            }
        }
        static void repeatPhrase2(String phrase, int number)
        {
            if (number != 0)
            {
                number -= 1;
                Console.WriteLine(phrase);
                repeatPhrase2(phrase, number);
            }
        }
    }
}