using RockPaperScissors.Contracts;
using System;

namespace RockPaperScissors
{
    public class Game : IGame
    {

        private Player humanPlayer;
        private Player cpuPlayer;
        private static PrintUtil printUtil = new PrintUtil();

        public void startGame()
        {
            string repeat = string.Empty;
            string name = string.Empty;
            do
            {
                if (name == string.Empty) 
                 name = printUtil.GreetOpponent();
                //create players
                this.humanPlayer = new Player(name);
                this.cpuPlayer = new Player("CPU");
                //start game message
                printUtil.StartGameMessage(humanPlayer);
                //Get users hand, Note check for valid entry
                var humanHandSign = printUtil.ChooseHandSign();
                this.humanPlayer.HandSign = humanHandSign;
                //Generate a random hand for computer
                this.cpuPlayer.HandSign = HandSign.MapRandomToMove();
                //compare choices
                //Declare winner
                Console.WriteLine(HandSign.GetWinner(this.humanPlayer, this.cpuPlayer));
                Console.WriteLine("If you want to continoue press Y");
                repeat = Console.ReadLine();
            } while (repeat == "Y");

            Console.ReadLine();
        }
    }
}


