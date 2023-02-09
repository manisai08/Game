using System;

namespace Game
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            bool restartGame = true;
            string user;
            string computer;
            string result;

            while (restartGame) 
            {
                user = "";
                computer = "";

                while (user != "ROCK" && user != "PAPER" && user != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    user = Console.ReadLine();
                    user = user.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("User: " + user);
                Console.WriteLine("Computer: " + computer);

                switch(user)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Its Draw!");
                        }
                        else if (computer == "PAPER") 
                        {
                            Console.WriteLine("You Lost!");
                        }
                        else
                        {
                            Console.WriteLine("You Win!");
                        }
                        break;

                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Its Draw!");
                        }
                        else
                        {
                            Console.WriteLine("You Lost!");
                        }
                        break;

                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Lost!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Win!");
                        }
                        else
                        {
                            Console.WriteLine("Its Draw!");
                        }
                        break;

                }

                //To restart the game
                // " Y " indicates yes to restart the game
                // " N " indicates no to restart the game

                Console.WriteLine("would you like to Restart the game (Y/N): ");
                result = Console.ReadLine();
                result = result.ToUpper();

                if (result == "Y")
                {
                    restartGame = true;
                }
                else 
                {
                    restartGame = false;
                }
            }
        }
    }
}
