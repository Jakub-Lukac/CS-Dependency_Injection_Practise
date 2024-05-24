using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    public class ComputerPlayer : IPlayer
    {
        private Random _rnd = new Random();
        public Choice GetGhoice()
        {
            return (Choice)_rnd.Next(0, 3);
        }
    }
}
