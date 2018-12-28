using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenTheTeams
{
    /*
     * Takes a number of players and tries to divide these into two even teams
     * The players get 3 points for winning a game and 1 point for a tie. 
     * Divide by the number of games played
     * 
     * 
     * Thoughts on future algorithms: 
     * Easy version: 	Each player gets points based on the number of goals made by the team. 					
	 *                  Points = goals made by own team / goals made by other team. 
     *                  This way, a close game 9 vs 10 gives almost the same points to players of both teams. 
     * Medium version: 	Dividing by the number of games played. 					
	 *                  Try to have players play with people they haven't played 
     *                  with before rather than having equally strong teams. 					
     * Hard version: 	The algorithm should take into account the players in the same / other team: 
     *                  If you're only playing with good players and win, it's less valuable. 					
	 *                  If you play with bad players and win, it's very valuable. 
     *                  (You're most likely the reason your team won)	
     *                  
     * Good links:
     * https://softwareengineering.stackexchange.com/questions/150732/strategy-algorithm-to-divide-fair-teams-based-on-history
     * https://en.wikipedia.org/wiki/Partition_problem
     */
    class DividePlayersAlgorithm
    {

        // This will be used for the more advanced algorithms, commented out for now
        /* 
        private Game[] games;
        public Game[] Games
        {
            set
            {
                games = value;
            }
        }
        */

        // First team
        private List<Player> team1;
        public List<Player> Team1
        {
            get
            {
                return team1; 
            }
        }

        // Second team
        private List<Player> team2;
        public List<Player> Team2
        {
            get
            {
                return team2;
            }
        }

        public DividePlayersAlgorithm()
        {
            team1 = new List<Player>();
            team2 = new List<Player>();
        }

        public void CalculateTeams(List<Player> players)
        {
            // empty the lists
            team1.Clear();
            team2.Clear();

            // calculate the points for each player: 3p for win, 1p for draw
            var sortedPlayers = new List<KeyValuePair<int, Player>>();
            foreach(Player player in players)
            {
                int points = player.RankingData.Wins * 3 + player.RankingData.Draws;
                player.Score = points;
                sortedPlayers.Add(new KeyValuePair<int, Player>(points,player));
            }

            // sort the list of players based on points
            sortedPlayers.Sort((x, y) => x.Key.CompareTo(y.Key));

            // divide the players in 2 equally large teams - using the parity function
            // First player goes to team 1, then two into team 2, two into team 1, etc. 
            bool firstteam = true;
            int twoIntoEachTeam = 1; // this is set to 1 the first iteration since only 1 player is sent to team 1
            foreach (var playerWithPoints in sortedPlayers)
            {
                if(firstteam)
                {
                    team1.Add(playerWithPoints.Value);
                }
                else
                {
                    team2.Add(playerWithPoints.Value);
                }
                twoIntoEachTeam--;
                if (twoIntoEachTeam == 0)
                {
                    twoIntoEachTeam = 2;
                    firstteam = !firstteam;
                }
            }          
        }

        // Return score of team. Input True for Team1, False for Team2
        public double GetTeamScore(bool isTeam1)
        {
            double teamScore = 0;
            if (isTeam1)
            {
                foreach (Player player in team1)
                {
                    teamScore += player.Score;
                }
            }
            else
            {
                foreach (Player player in team2)
                {
                    teamScore += player.Score;
                }
            }
            return teamScore;
        }

        // Moving a player from one team to the other. 
        // Second input is True if player should be moved Team1 -> Team2, false otherwise
        public void MovePlayer(int index, bool fromTeam1)
        {
            if(fromTeam1)
            {
                team2.Add(team1[index]);
                team1.RemoveAt(index);
            }
            else
            {
                team1.Add(team2[index]);
                team2.RemoveAt(index);
            }
        }
    }
}
