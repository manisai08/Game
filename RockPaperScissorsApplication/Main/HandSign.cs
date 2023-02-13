using RockPaperScissors.Contracts;
using RockPaperScissors.Model;
using System;
namespace RockPaperScissors
{
    public class HandSign : IHandSign
    {
        public Move move;
        public HandSign() { 
        }
        public HandSign(Move move)
        {
            this.move = move;
        }

        public  HandSign MapStringToMove(string userChoice)
        {
            switch (userChoice.ToUpper())
            {
                case "P":
                    return new HandSign(Move.Paper);
                case "S":
                    return new HandSign(Move.Scissors);
                case "R":
                    return new HandSign(Move.Rock);
            }
            return null;
        }

        public HandSign MapRandomToMove()
        {
            Random random = new Random();
            int cpuChoice = random.Next(0, 2);
            return GetHandSign(cpuChoice);
        }


        public HandSign GetHandSign(int cpuChoice)
        {
            switch (cpuChoice)
            {
                case 0:
                    return new HandSign(Move.Rock);
                case 1:
                    return new HandSign(Move.Paper);
                case 2:
                    return new HandSign(Move.Scissors);
            }
            return null;
        }

        /// <summary>
        /// Gets the winning move.
        /// </summary>
        /// <returns>The winning move.</returns>
        /// <param name="move">Handsign.</param>
        public Move GetWinningMove(Move move)
        {
            switch (move)
            {
                case Move.Rock:
                    return Move.Paper;
                case Move.Paper:
                    return Move.Scissors;
                default:
                    return Move.Rock;
            }
        }

        /// <summary>
        /// Gets the winner.
        /// </summary>
        /// <returns>The winner.</returns>
        /// <param name="player1">Handsign player1.</param>
        /// <param name="player2">Handsign player2.</param>
        public string GetWinner(Player player1, Player player2)
        {
            if (EvaluatePlayers(player1, player2).Equals(1))
            {
                return "Congrats " + player2.Name + " is the winner";
            }
            else if (EvaluatePlayers(player1, player2).Equals(2))
            {
                return "Congrats " + player1.Name + " is the winner";
            }
            else
            {
                return "Sorry, It's a Draw!";
            }
        }

        public int EvaluatePlayers(Player player1, Player player2) {
            if (GetWinningMove(player1.HandSign.move).Equals(player2.HandSign.move))
            {
                //return player2.HandSign.move; //player 1 loses to player 2
                return 1;
            }
            else if (GetWinningMove(player2.HandSign.move).Equals(player1.HandSign.move))
            {
                //return player1.HandSign.move; //player 2 loses to player 1
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
