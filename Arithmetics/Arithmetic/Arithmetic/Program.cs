using System;

namespace Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 3;

            // if you divide integer values will return an integer value, in this case
            // will return only 3.

            // casting is same as in java ex...

            double z = (double) x / y;

            // remind the jerarchy of operators 

            /*1. ()
             *2. *, /
             *3. +, - 
             */

            // for decrease or aument a variable can use this two ways

            z++;
            z += 1;

            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
