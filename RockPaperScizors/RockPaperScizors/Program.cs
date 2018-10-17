using System;

namespace RockPaperScizors
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private void RunGame()
        {
            int numberOfPlayers = GetNumberOfPlayers();

            ComputerPlayer ralph = new ComputerPlayer();

            HumanPlayer playerOne = new HumanPlayer();

            HumanPlayer playerTwo = new HumanPlayer();

            if(numberOfPlayers == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    string playerOneMove = playerOne.MakeMove();

                    string playerTwoMove = playerTwo.MakeMove();
                }
            }


        }

        private int GetNumberOfPlayers()
        {
            int players = 0;
            Console.WriteLine("2 player or 1 player?");
            string numberOfPlayers = Console.ReadLine();
            numberOfPlayers = numberOfPlayers.ToLower();

            if (numberOfPlayers == "one" || numberOfPlayers == "1")
            {
                players = 1;
            }

            else if (numberOfPlayers == "two" || numberOfPlayers == "2")
            {
                players = 2;
            }
            else
            {
                Console.WriteLine("Enter a number (1 or 2)");
                GetNumberOfPlayers();
            }

            return players;
        }
    }
}
