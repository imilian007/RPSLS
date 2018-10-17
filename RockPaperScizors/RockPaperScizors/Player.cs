using System;
namespace RockPaperScizors
{
    public abstract class Player
    {
        int numberOfWins = 0;
        public abstract string MakeMove();
    }
}
