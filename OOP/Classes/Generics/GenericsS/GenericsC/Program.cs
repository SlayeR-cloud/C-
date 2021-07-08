using System;

namespace GenericsC
{
    class Program
    {
        static void Main(string[] args)
        {
            // generic: "Not specific to a particular data type"
            // add <T> to: classes, methods, fields, etc.
            
            // allows for code re-usability for different data types

            int[] intArray = {1, 2, 3};
            double[] doubleArray = {1.0, 2.0, 3.0};
            String[] stringArray = {"One", "Two", "Three"};
            
            // image that we want to display every element of the arrays, if we use normally form to do it
            // we will need 3 methods, one for each data type, and that's no functional. instead of that 
            // use <T> generic form, let's see it
            
            DisplayElements(intArray);
            DisplayElements(doubleArray);
            DisplayElements(stringArray);
            
        }

        // use <T> to specify that is generic type, then pass T as an argument
        public static void DisplayElements<T>(T[] array)
        {
            foreach (T thing in array)
            {
                Console.Write(thing + " ");
            }

            Console.WriteLine();
        }
    }
}