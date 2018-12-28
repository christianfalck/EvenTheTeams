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
        // Function that returns players with random names and random ranking
        public static List<Player> RandomizePlayers(int numberOfPlayers)
        {
            List<Player> players = new List<Player>();
            Random random = new Random();
            for (int a = 0; a < numberOfPlayers; a++)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
                string name = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());
                Ranking ranking = new Ranking(random.Next(20), random.Next(20), random.Next(20));
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

        // Splittin all lines in a file and parsing a Player from each line
        public static List<Player> OpenFile(string path)
        {
            string readText = File.ReadAllText(path);
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

        // (" {0, -5} {1, -25} ", name, ranking.ToString()
        private static Player ParsePlayerFromString(string playerString)
        {
            string name = playerString.Substring(0, 12).Trim();
            if (string.IsNullOrEmpty(name)) MessageBox.Show("Error while loading file. No name available.");
            Ranking ranking = ParseRankingFromString(playerString.Substring(12));
            return new Player(name, ranking);
        }

        // "{0,-15} {1,-15} {2,-15}",wins ,draws,losses );
        private static Ranking ParseRankingFromString(string rankingString)
        {
            int wins = 0;
            int draws = 0;
            int losses = 0;
            try
            {
                wins = int.Parse(rankingString.Substring(0, 15).Trim());
                draws = int.Parse(rankingString.Substring(15, 15).Trim());
                losses = int.Parse(rankingString.Substring(30, 15).Trim());
            } catch(Exception e)
            {
                MessageBox.Show("Error while loading file. No ranking available.");
            }
            return new Ranking(wins, draws, losses);
        }
    }
}
