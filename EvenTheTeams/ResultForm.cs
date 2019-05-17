using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenTheTeams
{
    public partial class ResultForm : Form
    {
        // The class that holds the two balanced teams
        private DividePlayersAlgorithm dpa;

        // If this is created without a list of players, 
        // we generate 10 players to present the functionality of the algorithm
        public ResultForm() :this(FileHandler.RandomizePlayers(10))
        {
        }

        // Default constructor, where the players who should be divided is given as a parameter
        public ResultForm(List<Player> players)
        {
            InitializeComponent();
            dpa = new DividePlayersAlgorithm();
            dpa.CalculateTeams(players);
            CalculateAndPresentTeamsAndScores();
        }

        // Activating/Deactivating move buttons based on if a player in the list is selected or not
        private void UpdateGUI()
        {
            if(listBoxTeam1.SelectedIndex >= 0)
            {
                buttonMoveTo2.Enabled = true;
            }
            else
            {
                buttonMoveTo2.Enabled = false;
            }
            if (listBoxTeam2.SelectedIndex >= 0)
            {
                buttonMoveTo1.Enabled = true;
            }
            else
            {
                buttonMoveTo1.Enabled = false;
            }
        }

        // Used when moving a player from Team 1 to Team 2
        private void buttonMoveTo2_Click(object sender, EventArgs e)
        {
            dpa.MovePlayer(listBoxTeam1.SelectedIndex, true);
            CalculateAndPresentTeamsAndScores();
        }

        // Used when moving a player from Team 2 to Team 1
        private void buttonMoveTo1_Click(object sender, EventArgs e)
        {
            dpa.MovePlayer(listBoxTeam2.SelectedIndex, false);
            CalculateAndPresentTeamsAndScores();
        }

        // Presents the players with score and a total score below each team
        private void CalculateAndPresentTeamsAndScores()
        {
            listBoxTeam1.Items.Clear();
            listBoxTeam2.Items.Clear();
            int RunnersTeam1 = 0;
            int RunnersTeam2 = 0;
            foreach (Player player in dpa.Team1)
            {
                listBoxTeam1.Items.Add(player.Name + ": " + player.Score);
                if (player.IsRunner) RunnersTeam1++;
            }
            foreach (Player player in dpa.Team2)
            {
                listBoxTeam2.Items.Add(player.Name + ": " + player.Score);
                if (player.IsRunner) RunnersTeam2++;
            }
            labelPointsTeam1.Text = "" + dpa.GetTeamScore(true);
            labelPointsTeam2.Text = "" + dpa.GetTeamScore(false);
            labelRunnersTeam1.Text = "" + RunnersTeam1;
            labelRunnersTeam2.Text = "" + RunnersTeam2;
            UpdateGUI();
        }

        // When the user clicks on one of the listBoxes, the corresponding button should activate
        private void listBoxTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        // When the user clicks on one of the listBoxes, the corresponding button should activate
        private void listBoxTeam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }

    }
}
