using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the rows you want: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the columns you want: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            Console.Write("Symbol?: ");
            char symbol = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Your figure: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }
    }
}
