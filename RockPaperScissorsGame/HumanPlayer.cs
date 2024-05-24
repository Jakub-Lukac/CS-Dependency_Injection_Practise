using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    public class HumanPlayer : IPlayer
    {
        private readonly string[] _validChoices;

        public HumanPlayer()
        {
            _validChoices = new string[] { "R", "P", "S"};
        }
        public Choice GetGhoice()
        {
            string choice;
            Choice c = Choice.None;
            do
            {
                Console.Write("Select from the following choices : (R)ock / (P)aper / (S)cissors : ");
                choice = Console.ReadLine().Trim();
            } while (!_validChoices.Contains(choice));

            switch (choice)
            {
                case "R":
                    c = Choice.Rock;
                    break;
                case "P":
                    c = Choice.Paper;
                    break;
                case "S":
                    c = Choice.Scissors;
                    break;
                default:
                    Console.WriteLine("Invalid value!");
                    break;
            }

            return c;
        }
    }
}
