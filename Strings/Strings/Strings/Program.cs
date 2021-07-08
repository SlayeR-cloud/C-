using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // String tricks...
            string first_name = "Ssaylem";
            string last_name = "Murillo";
            //1. combine
            string full_name = first_name + " " + last_name;
            //2. convert to different types into strings
            int number = 42;
            string string_number = number.ToString(); // convertion
            //3. convert all string values in uppercase/lowercase
            string name = "dave";
            string new_name = name.ToUpper(); // also can be ToLower()
            //4. detect the first letter in a specific word
            string name_test = "John";
            bool jword_start = name_test.StartsWith('J');
            //5. detect if a string contains specific characters
            string word = "Friedyam";
            bool contain_chars = word.Contains("ya");
            //6. split method
            string call_number = "123-123-123123";
            // first parameter the original value, second the value you want
            string new_call_number = call_number.Replace("-", "");
            //7. insert method
            string username = "friedyam";
            // first parameter position, second parameter the char to add
            string new_username = username.Insert(0, "@");
            //8. string portion
            // first parameter initial position, second the number of caracters you want since
            // the first parameter
            string new_username2 = username.Substring(0,3);

            Console.WriteLine("1. TRICK");
            Console.WriteLine(full_name);
            Console.ReadLine();

            Console.WriteLine("2. TRICK");
            Console.WriteLine(string_number);
            Console.ReadLine();

            Console.WriteLine("3. TRICK");
            Console.WriteLine(new_name);
            Console.ReadLine();

            Console.WriteLine("4. TRICK");
            Console.WriteLine(jword_start);
            Console.ReadLine();

            Console.WriteLine("5. TRICK");
            Console.WriteLine(contain_chars);
            Console.ReadLine();

            Console.WriteLine("6. TRICK");
            Console.WriteLine(new_call_number);
            Console.ReadLine();

            Console.WriteLine("7. TRICK");
            Console.WriteLine(new_username);
            Console.ReadLine();

            Console.WriteLine("8. TRICK");
            Console.WriteLine(new_username2);
            Console.ReadLine();
        }
    }
}
