﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenTheTeams
{
    //Has a list of Player
    public partial class PlayerManager
    {
        private List<Player> players; // All available players
        private List<Player> nextGamePlayers; // Players selected for next game

        //Constructor
        public PlayerManager()
        {
            players = new List<Player>();
            nextGamePlayers = new List<Player>();
        }

        //Returns a copy of an element at the position = index
        public Player GetPlayer (int index)
        {
            return players[index];
        }

        //Returns a copy of an element at the position = index
        public Player GetNextPlayer(int index)
        {
            return nextGamePlayers[index];  
        }

        //Property for the number
        public int Count
        {
            get { return players.Count; }
        }

        //Property for the number
        public int CountNext
        {
            get { return nextGamePlayers.Count; }
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

        // Get all available players
        public List<Player> GetAllPlayers()
        {
            return players;
        }

        // Get all players for next game: Used in the ResultForm
        public List<Player> GetNextGamePlayers()
        {
            return nextGamePlayers;
        }

        public string[] GetNextPlayersInfo()
        {
            var nextPlayersInfo = new string[CountNext];
            for (int i = 0; i < CountNext; i++)
            {
                nextPlayersInfo[i] = GetNextPlayer(i).Name.ToString();
            }
            return nextPlayersInfo;
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

        //Add a new object to the list
        public bool AddNextPlayer(int index)
        {
            Player player = GetPlayer(index);
            if (player != null)
            {
                nextGamePlayers.Add(player);
                return true;
            }
            else
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

        //Remove the object at position = index from the list
        public bool DeleteNextPlayer(int index)
        {
            bool ok = false;
            if (CheckNextIndex(index))
            {
                nextGamePlayers.RemoveAt(index);
                ok = true;
            }
            return ok;
        }

        //Change the values of object at position = index in the list
        public bool ChangePlayer(Player playerIn, int index)
        {
            bool ok = false;
            if ((playerIn != null) && CheckIndex(index))
            {
                players[index] = playerIn;
                ok = true;
            }
            return ok;
        }

        //Check index
        public bool CheckIndex(int index)
        {
            return (index >= 0) && (index < players.Count);
        }

        //Check index
        public bool CheckNextIndex(int index)
        {
            return (index >= 0) && (index < nextGamePlayers.Count);
        }

        // Sort players based on points
        public void SortPlayers(bool highestScoreFirst)
        {
            if(highestScoreFirst)
                players.Sort((x, y) => x.Score.CompareTo(y.Score));
            else
                players.Sort((x, y) => y.Score.CompareTo(x.Score));
        }
    }
}
