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
    //Has a list of Player
    public partial class PlayerManager
    {
        private List<Player> players;

        //Constructor
        public PlayerManager()
        {
            players = new List<Player>();
        }

        //Returns a copy of an element at the position = index
        public Player GetPlayer (int index)
        {
            Player copyObj = new Player(players[index]);
            return copyObj;
        }

        //Property for the number
        public int Count
        {
            get { return players.Count; }
        }

        //Get headings
        public string GetHeading()
        {
            Player custObj = new Player();
            return custObj.GetToStringItemsHeadings;
        }
        //Get all players info in a list
        public string[] GetPlayersInfo()
        {
            var playersInfo = new string[Count];
            for (int i = 0; i < Count; i++)
            {
                playersInfo[i] = GetPlayer(i).ToString();
            }
            return playersInfo;
        }

        //Get all players for next game
        public List<Player> GetNextGamePlayers()
        {
            return players;
        }

        //Add a new object to the list
        public bool AddPlayer(Player playerIn)
        {
            if (playerIn != null)
            {
                players.Add(playerIn);
                return true;
            }
            return false;
        }

        //Remove the object at position = index from the list
        public bool DeletePlayer(int index)
        {
            bool ok = false;
            if (CheckIndex(index))
            {
                players.RemoveAt(index);
                ok = true;
            }
            return ok;
        }

        //Check index
        public bool CheckIndex(int index)
        {
            return (index >= 0) && (index < players.Count);
        }
    }
}
