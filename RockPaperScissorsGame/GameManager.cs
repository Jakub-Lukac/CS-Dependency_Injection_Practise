using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    public class GameManager
    {
        private IPlayer _player1;
        private IPlayer _player2;

        // constructor dependency injection
        public GameManager(IPlayer player1, IPlayer player2)
        {
            _player1 = player1;
            _player2 = player2;
        }
        public GameStatus PlayRound()
        {
            // initialize player 1 hand (choice) (user input)
            Choice c1 = _player1.GetGhoice();

            // initialize player 2 hand (choice) (random - computer)
            Choice c2 = _player2.GetGhoice();

            Console.WriteLine($"Player 1 chose : {c1}");
            Console.WriteLine($"Player 2 chose : {c2}");

            // compare players' choices

            if (c1 == c2)
            {
                return GameStatus.Draw;
            }

            if((c1 == Choice.Rock && c2 == Choice.Scissors)
                || (c1 == Choice.Scissors && c2 == Choice.Paper)
                || (c1 == Choice.Paper && c2 == Choice.Rock)) 
            {
                return GameStatus.Player1Wins;
            }

            return GameStatus.Player2Wins;
        }

        public void GameMessage(GameStatus status)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            switch (status)
            {
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
                case GameStatus.Draw:
                    Console.WriteLine("Draw!");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public enum Choice
    {
        Rock,
        Paper,
        Scissors,
        None
    }

    public enum GameStatus
    {
        Player1Wins,
        Player2Wins,
        Draw
    }
}
