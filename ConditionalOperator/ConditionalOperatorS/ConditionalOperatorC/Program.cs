using System;

namespace ConditionalOperatorC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional operator: used in conditional assignment 
            // if a condition is true/false
            
            // functioning:  (condition) ? x : y
            // if its true do x, if is false do y

            // it's necessary to assign the values to something
            // so use message at the beginning for that
            // parenthesis in the condition are redundant
            
            double temperature = 20;
            String message;

            message = temperature >= 15 ? "It's warm outside" : "It's cold outside";
            
            Console.WriteLine(message);

        }
    }
}