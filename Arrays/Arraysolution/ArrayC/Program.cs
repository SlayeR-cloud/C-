using System;

namespace ArrayC
{
    class Program
    {
        static void Main(string[] args)
        {
            // same as java
            String[] arrayObjects = {"newCar", "secondNewCar", "Etc"};
            String[] newObjectsArray = new string[100];
            
            // for each statement
            foreach (String s in arrayObjects)
            {
                Console.WriteLine(s);
            }
            // with normal for
            for (int i = 0; i < arrayObjects.Length; i++)
            {
                Console.WriteLine(arrayObjects[i]);
            }

            /*
            foreach (var s in newObjectsArray)
            {
                Console.WriteLine(s);
            }
            */
            if(newObjectsArray[1] != null)
                Console.WriteLine(newObjectsArray[1]);
            else
                Console.WriteLine("empty array");
           
        }
    }
}