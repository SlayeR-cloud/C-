using System;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);
                while (guess != number)
                {

                    Console.Write($"Guess the number between {min} and {max}: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > number)
                    {
                        Console.WriteLine("Too high");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Too low");
                    }
                    guesses++;
                }
                Console.WriteLine("\nNumber: " + number);
                Console.WriteLine("You win!");
                Console.WriteLine("Guesses: " + guesses);

                Console.Write("Play again? (y/n): ");
                response = Console.ReadLine();
                response = response.ToLower();
                if(response == "n")
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Come back later :) !!!");
        }
    }
}
