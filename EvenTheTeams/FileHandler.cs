//Christian Falck
//HT2018-DA204B-88221
//Project 

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
                Ranking ranking = new Ranking(random.Next(20), random.Next(20), random.Next(20), random.Next(20)); // randomize ranking
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
        private static Player ParsePlayerFromString(string playerString)
        {
            string name = playerString.Substring(0, 20).Trim();
            if (string.IsNullOrEmpty(name)) MessageBox.Show("Error while loading file. No name available.");
            Ranking ranking = ParseRankingFromString(playerString.Substring(20));
            return new Player(name, ranking);
        }

        // Ranking is parsed into wins, draws, losses and goals. 
        // Each value can be maximum 5 characters in the file
        private static Ranking ParseRankingFromString(string rankingString)
        {
            int wins = 0;
            int draws = 0;
            int losses = 0;
            int goals = 0;
            try
            {
                wins = int.Parse(rankingString.Substring(0, 6).Trim());
                draws = int.Parse(rankingString.Substring(6, 6).Trim());
                losses = int.Parse(rankingString.Substring(12, 6).Trim());
                goals = int.Parse(rankingString.Substring(18, 6).Trim());
            } catch(Exception e)
            {
                MessageBox.Show("Error while loading file. No ranking available.");
            }
            return new Ranking(wins, draws, losses, goals);
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
            double[] calculatedScorePerWin = ScorePerGame(scores);

            List<Player> players = new List<Player>();
            for (int index = 1; index < lines.Length; index++)
            {
                players.Add(ParsePlayerFromCSV(lines[index],calculatedScorePerWin));
            }
            return players;
        }

        /*
         * Calculating the score per game 
         * Each player will get a score for participating = own team goals / other team goals
         * 
         * If one of the teams did not do any goals, both teams will be rewarded 1 to avoid 
         * dividing with zero. Open for other suggestions!
         * 
         * Potential problem: Is a team scoring 14-1 twice as good as a team scoring 14-2? 
         * Ideas for solving: Maximum score. Let's start with using 3 as maximum score. 
         */
        private static double[] ScorePerGame(string[] scores)
        {
            double[] calculatedScorePerWin = new double[scores.Length]; // goals / opponents goals
            for(int index = 1; index < scores.Length; index++)
            {
                string score = scores[index];
                int winningTeamGoals = int.Parse(score.Substring(0, score.IndexOf('-')).Trim());
                int losingTeamGoals = int.Parse(score.Substring(score.IndexOf('-')+1).Trim());
                if(losingTeamGoals == 0) // Avoid dividing with 0
                {
                    winningTeamGoals++;
                    losingTeamGoals++;
                }
                calculatedScorePerWin[index] =  (double)winningTeamGoals / (double)losingTeamGoals;
                if (calculatedScorePerWin[index] > 3) calculatedScorePerWin[index] = 3; // max score 3
            }

            return calculatedScorePerWin;
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
        private static Player ParsePlayerFromCSV(string playerData, double[] scores)
        {
            Player player = new Player();
            string[] gamesAttended = playerData.Split(',');
            player.Name = gamesAttended[0]; // First column is player name
            double numberOfGamesPlayed = 0;
            double accumulatedScore = 0;
            Ranking rank = new Ranking();
            for (int index = 1; index < gamesAttended.Length; index++)
            {
                if(gamesAttended[index] == "W")
                {
                    numberOfGamesPlayed++;
                    accumulatedScore += scores[index];
                    rank.Wins++;
                }
                else if (gamesAttended[index] == "L")
                {
                    numberOfGamesPlayed++;
                    accumulatedScore += (1/scores[index]); // 1/(other/own) = own/other
                    rank.Losses++;
                }
                else if (gamesAttended[index] == "A" || gamesAttended[index] == "B") // Draw
                {
                    numberOfGamesPlayed++;
                    accumulatedScore += scores[index]; // should be 1
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
