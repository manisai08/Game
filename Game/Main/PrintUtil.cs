using System;
namespace RockPaperScissors
{
    public class PrintUtil
    {
        public string GreetOpponent()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors! It's you against the CPU.");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("{0} indicate that you are ready by hitting the enter key", name);
            return name;
        }

        public void StartGameMessage(Player player)
        {
            Console.WriteLine("{0} ,let's Play!\n", player.Name);
        }

        public HandSign ChooseHandSign()
        {
            //Accept user input in various ways
            Console.WriteLine("R-Rock\n" +
                              "P-Paper\n" +
                              "S-Scissors\n" +
                              "Make your selection:");
            string input = Console.ReadLine();
            var handSign = HandSign.MapStringToMove(input);
            if (handSign == null)
            {
                Console.WriteLine("Sorry Invalid. Please choose again");
                return ChooseHandSign();
            }
            return handSign;
        }
    }
}


