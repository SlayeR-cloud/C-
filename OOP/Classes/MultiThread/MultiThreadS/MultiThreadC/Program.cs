using System;
using System.Threading;
namespace MultiThreadC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thread: an execution path of a program 
            /* We can use multiple threads to perform different tasks 
             * of our program at the same time, current thread running
             * is "main" thread.
             * Using System.Threading;
             */
            
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name);
            
            // In this example we will use the threads to perform 2 timers at the same time, one to count to ten
            // and the other to count to one, (reverse)
            
            
            /* if this methods are called just execute in the same thread, one by one 
            CountDown();
            CountUp();
            */
            
            // creating new threads, pass to the constructor the operation to do, in this case 
            // every method CountUp and CountDown
            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);
            // it is necessary to call the start method
            thread1.Start();
            thread2.Start();
            
            // Main thread is running in the background
            Console.WriteLine(mainThread.Name + " is complete!");
            // if our method has parameters, its necessary to use in the thread constructor the "lambda" expression
            // Thread variableName = new Thread( () => Method(Arguments) ) and that's all
            
        }

        static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1: " + i + " seconds");
                Thread.Sleep(1000); // this will sleep this task 1 second while during each iteration 
            }
        }

        static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2: " + i + " seconds");
                Thread.Sleep(1000);
            }
        }
    }
}