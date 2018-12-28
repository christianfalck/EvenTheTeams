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

        private DividePlayersAlgorithm dpa; 

        public ResultForm() :this(FileHandler.RandomizePlayers(10))
        {
        }

        public ResultForm(List<Player> players)
        {
            InitializeComponent();
            dpa = new DividePlayersAlgorithm();
            dpa.CalculateTeams(players);
            CalculateAndPresentTeamsAndScores();
        }

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

        private void buttonMoveTo2_Click(object sender, EventArgs e)
        {
            FileHandler.SaveFile(dpa.Team1,"test.txt");
            dpa.MovePlayer(listBoxTeam1.SelectedIndex, true);
            CalculateAndPresentTeamsAndScores();
        }

        private void buttonMoveTo1_Click(object sender, EventArgs e)
        {
            dpa.MovePlayer(listBoxTeam2.SelectedIndex, false);
            CalculateAndPresentTeamsAndScores();
        }

        private void CalculateAndPresentTeamsAndScores()
        {
            listBoxTeam1.Items.Clear();
            listBoxTeam2.Items.Clear();
            foreach (Player player in dpa.Team1)
            {
                listBoxTeam1.Items.Add(player.Name + ": " + player.Score);
            }
            foreach (Player player in dpa.Team2)
            {
                listBoxTeam2.Items.Add(player.Name + ": " + player.Score);
            }
            labelPointsTeam1.Text = "" + dpa.GetTeamScore(true);
            labelPointsTeam2.Text = "" + dpa.GetTeamScore(false);
            UpdateGUI();
        }

        private void listBoxTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void listBoxTeam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {

        }
    }
}
