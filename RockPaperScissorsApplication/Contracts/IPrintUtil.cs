using RockPaperScissors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.Contracts
{
    public interface IPrintUtil
    {
        string GreetOpponent();
        void StartGameMessage(Player player);
        HandSign GetHandSign();
        HandSign ChooseHandSign(string sign);
    }
}
