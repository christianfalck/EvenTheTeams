using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenTheTeams
{
    public class Player
    {
        string name = string.Empty;
        Ranking ranking = new Ranking();
        double score = 0;

        //This variable is a crude first version of the support of skills for players based on the theory that stamina is a crucial factor for success
        bool isRunner;

        //Constructor
        public Player()
        {

        }

        //Constructor
        public Player(string name, Ranking ranking)
        {
            this.name = name;
            this.ranking = ranking;
        }

        //Properties
        public string Name
        {
            get { return name; }

            set {
                if (value != String.Empty)
                    name = value;  }
        }

        public Ranking RankingData
        {
            get { return ranking; }

            set
            {
                if (value != null)
                    ranking = value;
            }
        }

         // Score is used by the algorithm to divide players into two groups
        // where the total score of the players in the two groups should be close to eachother
        public double Score
        {
            get { return score; }
            set { score = value; }
        }

        //A formatted string as heading for the values formatted in the ToString
        public string GetToStringItemsHeadings
        {
            get { return string.Format("{0, -55} {1, -35} {2, -40} ", "Name", "Score", ranking.GetToStringItemsHeadings); }
        }

        // Delivers a formatted string with data stored in the object.
        public override string ToString()
        {
            string strOut = string.Format(" {0, -30} {1, -20} {2, -40} ", name, score, ranking.ToString());
            return strOut;
        }

    }
}
