using System;
namespace RockPaperScissors
{
    public class Player
    {
        private string name;
        private HandSign handSign;


        public Player(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public HandSign HandSign
        {
            get { return handSign; }
            set { handSign = value; }
        }

    }
}
