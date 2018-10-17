using System;
namespace RockPaperScizors
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer()
        {

        }

        public override string MakeMove()
        {
            Console.WriteLine("I'm Ralph. Good luck mortal human, I never lose");
            string x = "yu yu";
            return x;
        }
    }
}
