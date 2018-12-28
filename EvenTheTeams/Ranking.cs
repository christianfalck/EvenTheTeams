//Lena Lindblad
//HT2018-DA204B-88221
//Project 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenTheTeams
{
    //Class for data to give ranking points
    public class Ranking
    {
        private int wins;
        private int draws;
        private int losses;
        private int goals;

        public Ranking()
        {
            Initialize();
        }

        private void Initialize()
        {
            wins = 0;
            draws = 0;
            losses = 0;
            goals = 0;
        }

        public Ranking (int wins, int draws, int losses)
        {
            this.wins = wins;
            this.draws = draws;
            this.losses = losses;
        }

        //Properties
        public int Wins
        {
            get { return wins; }

            set { wins = value;  }
        }

        public int Draws
        {
            get { return draws; }

            set { draws = value; }
        }

        public int Losses
        {
            get { return losses; }

            set { losses = value; }
        }

        public int Goals
        {
            get { return goals; }

            set { losses = value; }
        }

        //A formatted string as heading for the values formatted in the ToString
        public string GetToStringItemsHeadings
        {
            get { return string.Format("{0,-10} {1,-10} {2,-10} {3,-10}", "wins", "draws", "losses", "goals"); }
        }

        // Delivers a formatted string with data stored in the object.
        public override string ToString()
        {
            string strOut = string.Format("{0,-10} {1,-10} {2,-10} {3,-10}", wins ,draws,losses, goals );
            return strOut;
        }
    }
}
