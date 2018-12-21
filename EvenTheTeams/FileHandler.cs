using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenTheTeams
{
    class FileHandler
    {
        // Function that returns 10 players with random names and random ranking
        public Player[] OpenFile(string path)
        {
            int numberOfPlayers = 10;
            Player[] players = new Player[numberOfPlayers];
            for (int a = 0; a < 10; a++)
            {
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
                string name = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());
                Ranking ranking = new Ranking(random.Next(20), random.Next(20), random.Next(20));
                players[a] = new Player(name, ranking);
            }
            return players;
        }
    }
}
