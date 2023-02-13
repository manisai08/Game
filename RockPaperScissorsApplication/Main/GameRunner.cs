using RockPaperScissors.Contracts;
using System;

namespace RockPaperScissors
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            IHandSign ihandSign = new HandSign();
            IPrintUtil iprintUtil = new PrintUtil(ihandSign);
            IGame game = new Game(ihandSign, iprintUtil);
            game.startGame();

        }
    }
}


