using System;
namespace RockPaperScissorsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option;
            do
            {
                GameManager gm = new GameManager(new HumanPlayer(), new ComputerPlayer());

                GameStatus status =  gm.PlayRound();

                gm.GameMessage(status);

                Console.Write("Do you wish to play another round ? (y/n) : ");
                option = Console.ReadLine().ToLower().Trim();
            } while (option == "y");
        }
    }
}
