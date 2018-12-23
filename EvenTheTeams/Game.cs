using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenTheTeams
{
    class Game
    {

        private Player[] team1;
        private Player[] team2;

        public Game()
        {

        }

        public Player[] Team1
        {
            get
            {
                return team1;
            }
            set
            {
                team1 = value;
            }
        }

        public Player[] Team2
        {
            get
            {
                return team2;
            }
            set
            {
                team2 = value;
            }
        }

    }
}
