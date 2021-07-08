using System;

namespace StringIC
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation: allow us to insert variables 
            // into a string literal, precede a string literal with
            // $ symbol and {} are placeholders (marcadores de posicion)

            // also in the placeholders can add a second argument
            // {variable, integervalue} 
            
            // if its + will be tabs before the variable
            
            // if its - will be tabs after the variable 
            
            String name = "Dave";
            int age = 1000;
            
            Console.WriteLine($"Hi {name}, you are {age, -10} years old");
            
        }
    }
}