using System;

namespace HelloWorld{
    class Program {
        static void Main(string[] args){
            // WriteLine: Writes a line with a \n 
            // Write: Write line next by line

            /*
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            */

            // Variables -> first define the variable type, then the name and last value
            // can use a const type variable before the type, to create a constant value
            // ex: const int gravity = 10;
            
            string stringvalue = "This is a number";
            bool boolvalue = true;
            char charvalue = 'y';
            double doublevalue = 52;
            int intvalue = 100;
            Console.WriteLine("String value: " + stringvalue + "\n" +
                "Int value: " + intvalue + "\nChar value: " + charvalue + "\nBoolean value: "+ boolvalue +
                "\nDouble value: " + doublevalue);
            Console.WriteLine(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
