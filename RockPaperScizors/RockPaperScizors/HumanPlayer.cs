using System;
namespace RockPaperScizors
{
    public class HumanPlayer : Player
    {
        string gesture;
        public HumanPlayer()
        {
        }
        public override string MakeMove()
        {
            Console.WriteLine("Which gesture will you make?");
            gesture = Console.ReadLine();
            gesture = gesture.ToLower();
            return gesture;
        }
    }
}
