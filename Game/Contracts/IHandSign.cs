using RockPaperScissors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Contracts
{
    interface IHandSign
    {
        HandSign MapStringToMove(string userChoice);

        HandSign MapRandomToMove();

        Move GetWinningMove(Move move);




    }
}
