using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenTheTeams
{
    class FileHandler
    {
        // Function that gererate players with random names and random ranking
        public static List<Player> RandomizePlayers(int numberOfPlayers)
        {
            List<Player> players = new List<Player>();
            Random random = new Random();
            for (int a = 0; a < numberOfPlayers; a++)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ"; // All available letters in the name
                string name = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray()); // randomize a name
                Ranking ranking = new Ranking(random.Next(20), random.Next(20), random.Next(20)); // randomize ranking
                players.Add(new Player(name, ranking));
            }
            return players;
        }

        // Saving the Players according to the format in the ToString function in Player and Ranking
        public static void SaveFile(List<Player> players, string path)
        {
            string textToSave = "";
            foreach(Player player in players)
            {
                textToSave += player.ToString() + Environment.NewLine;
            }
            File.WriteAllText(path, textToSave);
        }

        // Splitting all lines in a file and parsing a Player from each line
        public static List<Player> OpenFile(string path)
        {
            string readText = File.ReadAllText(path);
            // Following is the code that splits each row into a string in an array
            string[] lines = readText.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None
            );
            List<Player> players = new List<Player>();
            foreach(string line in lines)
            {
                if (string.IsNullOrEmpty(line.Trim())) break; // last line will always be empty
                players.Add(ParsePlayerFromString(line));
            }
            return players;
        }

        // Player data is parsed into a 20-character name and ranking being the rest
        // TODO save as a CSV file instead: That way file loading/saving isn't
        // depending on formatting 
        // TODO 2: Save the resulting two teams.. the list of players isn't interesting
        private static Player ParsePlayerFromString(string playerString)
        {
            string name = playerString.Substring(0, 20).Trim();
            if (string.IsNullOrEmpty(name)) MessageBox.Show("Error while loading file. No name available.");
            Ranking ranking = ParseRankingFromString(playerString.Substring(15));
            return new Player(name, ranking);
        }

        // Ranking is parsed into wins, draws and losses. 
        // Each value can be maximum 5 characters in the file
        private static Ranking ParseRankingFromString(string rankingString)
        {
            int wins = 0;
            int draws = 0;
            int losses = 0;
            try
            {
                wins = int.Parse(rankingString.Substring(0, 6).Trim());
                draws = int.Parse(rankingString.Substring(6, 6).Trim());
                losses = int.Parse(rankingString.Substring(12, 6).Trim());
            } catch(Exception e)
            {
                MessageBox.Show("Error while loading file. No ranking available.");
            }
            return new Ranking(wins, draws, losses);
        }

        // Splitting all lines in a file and parsing a Player from each line
        public static List<Player> OpenCSV(string path)
        {
            string readText = File.ReadAllText(path);
            // Following is the code that splits each row into a string in an array
            string[] lines = readText.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None
            );
            // First line is the scores
            string[] scores = lines[0].Split(',');
            double[] calculatedScoreGame = ScorePerGame(scores);

            List<Player> players = new List<Player>();
            for (int index = 1; index < lines.Length; index++)
            {
                players.Add(ParsePlayerFromCSV(lines[index], calculatedScoreGame));
            }
            return players;
        }

        /*
         * Calculating the score per game 
         * 
         * Losing team will get [losing team goals / winning team goals] points
         * Winning team will get [2 - losing team goals / winning team goals] points
         * 
         * If any of the teams score 0 goals, both teams will be rewarded 1 goal to avoid dividing with zero. 
         * 
         * This algorithm will result in average score = 1. 
         * 
         * DEPRECATED ALGORITHM
         * Using the following algorithm will result in average being > 1 since 10-5 will grant 2 and 0.5 points => Average = 1.25
         * Each player will get a score for participating = own team goals / other team goals
         * If one of the teams did not do any goals, both teams will be rewarded 1 to avoid 
         * dividing with zero. Open for other suggestions!
         * Potential problem: Is a team scoring 14-1 twice as good as a team scoring 14-2? 
         * Ideas for solving: Maximum score. Let's start with using 3 as maximum score. 
         */
        private static double[] ScorePerGame(string[] scores)
        {
            double[] calculatedScorePerGame = new double[scores.Length]; // goals / opponents goals
            for(int index = 2; index < scores.Length; index++)
            {
                string score = scores[index];
                int winningTeamGoals = int.Parse(score.Substring(0, score.IndexOf('-')).Trim());
                int losingTeamGoals = int.Parse(score.Substring(score.IndexOf('-')+1).Trim());
                if(losingTeamGoals == 0) // Avoid dividing with 0
                {
                    winningTeamGoals++;
                    losingTeamGoals++;
                }
                calculatedScorePerGame[index] =  (double)losingTeamGoals / (double)winningTeamGoals;
            }
            return calculatedScorePerGame;
        }

        /*
         * The player score is the average score of all the games played. 
         * Win > 1
         * Draw = 1
         * Lose < 1
         * Adding all scores and dividing with number of games gives player score. 
         * An average score of 1+ means you have a player better than average. 
         * 
         * A player with no games played is given the score of 1 (benefit of doubt)
         */
        private static Player ParsePlayerFromCSV(string playerData, double[] scoresForLosing)
        {
            Player player = new Player();
            string[] gamesAttended = playerData.Split(',');
            player.Name = gamesAttended[0]; // First column is player name
            player.IsRunner = (gamesAttended[1]=="Y"); // Second column indicates if the player is a runner
            double numberOfGamesPlayed = 0;
            double accumulatedScore = 0;
            Ranking rank = new Ranking();
            for (int index = 2; index < gamesAttended.Length; index++)
            {
                if(gamesAttended[index] == "W")
                {
                    numberOfGamesPlayed++;
                    accumulatedScore += (2-scoresForLosing[index]); // see comment ScorePerGame
                    rank.Wins++;
                }
                else if (gamesAttended[index] == "L")
                {
                    numberOfGamesPlayed++;
                    accumulatedScore += scoresForLosing[index]; // see comment ScorePerGame
                    rank.Losses++;
                }
                else if (gamesAttended[index] == "A" || gamesAttended[index] == "B") // Draw
                {
                    numberOfGamesPlayed++;
                    accumulatedScore += scoresForLosing[index]; // should be 1
                    rank.Draws++;
                }
            }
            player.RankingData = rank;
            if (numberOfGamesPlayed >= 1)
                player.Score = Math.Round((accumulatedScore / numberOfGamesPlayed),2);
            else
                player.Score = 1;
            return player;
        }
    }
}
