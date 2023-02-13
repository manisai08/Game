using RockPaperScissors.Contracts;
using System;

namespace RockPaperScissors
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            IGame game = new Game();
            game.startGame();

        }
    }
}


