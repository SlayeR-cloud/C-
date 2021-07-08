using System;
using System.Collections.Generic;
namespace ListC
{
    class Program
    {
        static void Main(string[] args)
        {
            /* List: data structure that represents a list of objects that can be accessed by index
             * similar to an array, but can dynamically increase/decrease in size during runtime
             * using System.Collections.Generic;
             */

            List<string> food = new List<string>();
            food.Add("Fried potatos");
            food.Add("Pizza");
            
            // 1. to access an item is same as an array type -> food[index] and that's all
            // 2. to remove just use Remove method 
            // 3. to insert just use Insert method
            // 4. to have the size of the list use Count method
            // 5. to have certain index of an element type -> food.IndexOf(element)
            // 6. if we have duplicate elements maybe can use food.LastIndexOf(element) this will return
            // the last index where the element is founded
            // 7. use Sort method to sort :)
            // 8. use Reverse method to have the elements in reverse mode of they was added
            // 9. use Clear method to clear the list (this will delete all elements)
            // 10. can create an array copy through the ToArray() method
            
            
            foreach (string item in food)
            {
                Console.WriteLine(item);
            }
        }
    }
}