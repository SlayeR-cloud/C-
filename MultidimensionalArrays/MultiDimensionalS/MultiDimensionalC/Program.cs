using System;

namespace MultiDimensionalC
{
    class Program
    {
        static void Main(string[] args)
        {
            // for a string of vehicles... can use a matrix
            String[] vehicle1 = {"Ford", "F-120", "Explorer"};
            String[] vehicle2 = {"Chevy", "Camaro", "Silverado"};
            String[] vehicle3 = {"Corolla", "Camry", "RAV4"};

            String[,] parking = {
                {"Ford", "F-120", "Explorer"},
                {"Chevy", "Camaro", "Silverado"}, 
                {"Corolla", "Camry", "RAV4"},
                {"Lamborghini", "nn", "nn"}
                
            };
        
            
            // to access for example "Explorer" value, there are 3 rows,
            // so use [row, column]. in this case, will be

            parking[0, 2] = "Fusion"; // this will change the value "Explorer" to "Fusion"

            // this will iterate 9 times
            foreach (String car in parking)
            {
                Console.WriteLine(car);
            }

            // parking.GetLenght(0), 0 is for first dimension (rows) , 1 for the next dimension (columns)
            // x and y

            for (int i = 0; i < parking.GetLength(0); i++)
            {
                for (int j = 0; j < parking.GetLength(1); j++)
                {
                    Console.Write(parking[i, j] + " - ");
                }

                Console.WriteLine();
            }
            
            int value = parking.GetLength(0);
            int value2 = parking.GetLength(1);
        }
    }
}