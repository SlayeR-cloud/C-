using System;

namespace GameRockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool again = true;
            String player;
            String computer;
            while (again)
            {
                player = "";
                computer = ""; 

                while(player != "rock" && player != "paper" && player != "scissors")
                {
                    Console.Write("Enter rock, paper, or scissors: ");
                    player = Console.ReadLine();
                    player = player.ToLower();

                }

                int randomNum = random.Next(1, 4);

                switch (randomNum)
                {
                    case 1:
                        computer = "rock";
                        break;
                    case 2:
                        computer = "paper";
                        break;
                    default:
                        computer = "scissors";
                        break;
                }

                Console.WriteLine("Player choice: " + player);
                Console.WriteLine("Computer choice: " + computer);

                switch (player)
                {
                    case "rock":
                        if (computer == "rock")
                        {
                            Console.WriteLine("Draw!!!");
                        }
                        else if (computer == "paper")
                        {
                            Console.WriteLine("You lose !");
                        }
                        else
                        {
                            Console.WriteLine("You WIN !");
                        }
                        break;
                    case "paper":
                        if (computer == "paper")
                        {
                            Console.WriteLine("Draw!!!");
                        }
                        else if (computer == "scissors")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You WIN !");
                        }
                        break;
                    default:
                        if (computer == "scissors")
                        {
                            Console.WriteLine("Draw!!!");
                        }
                        else if (computer == "rock")
                        {
                            Console.WriteLine("You lose !");
                        }
                        else
                        {
                            Console.WriteLine("You WIN !");
                        }
                        break;
                }

                Console.WriteLine("Play again? y/n: ");
                string answer = Console.ReadLine();
                answer = answer.ToLower();
                if (answer == "n")
                {
                    again = false;
                }

            }
            Console.WriteLine("Come back later!!! :)");
        }
    }
}