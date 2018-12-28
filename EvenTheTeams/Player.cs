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
    public class Player
    {
        string name = string.Empty;
        Ranking ranking = new Ranking();


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

        //Copy Constructor
        public Player(Player other)
        {
            this.name = other.name;
            this.ranking = other.ranking;
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
        //A formatted string as heading for the values formatted in the ToString
        public string GetToStringItemsHeadings
        {
            get { return string.Format("{0, -5} {1, -25} ", "Name", ranking.GetToStringItemsHeadings); }
        }

        // Delivers a formatted string with data stored in the object.
        public override string ToString()
        {
            string strOut = string.Format(" {0, -5} {1, -25} ", name, ranking.ToString());
            return strOut;
        }

    }
}
