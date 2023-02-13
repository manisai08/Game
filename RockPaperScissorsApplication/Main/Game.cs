using RockPaperScissors.Contracts;
using RockPaperScissors.Model;
using System;

namespace RockPaperScissors
{
    public class Game : IGame
    {

        private Player humanPlayer;
        private Player cpuPlayer;
        private readonly IPrintUtil printUtil;

        private readonly IHandSign handSign;

        public Game(IHandSign ihandSign, IPrintUtil iprintUtil) {
            handSign = ihandSign;
            printUtil = iprintUtil;
        }

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
                var humanHandSign = printUtil.GetHandSign();
                this.humanPlayer.HandSign = humanHandSign;
                
                //Generate a random hand for computer
                this.cpuPlayer.HandSign = handSign.MapRandomToMove();
                
                //compare choices
                //Declare winner
                Console.WriteLine(handSign.GetWinner(this.humanPlayer, this.cpuPlayer));
                Console.WriteLine("If you want to continoue press Y");
                repeat = Console.ReadLine();
            } while (repeat == "Y");
            Console.ReadLine();
        }
    }
}


