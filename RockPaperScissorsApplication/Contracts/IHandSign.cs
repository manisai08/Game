using RockPaperScissors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Contracts
{
    public interface IHandSign
    {
        HandSign MapStringToMove(string userChoice);
        HandSign MapRandomToMove();
        Move GetWinningMove(Move move);
        string GetWinner(Player player1, Player player2);
        int EvaluatePlayers(Player player1, Player player2);
    }
}
