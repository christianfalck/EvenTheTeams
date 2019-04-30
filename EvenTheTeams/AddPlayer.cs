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
    //Player form, fill in player's data
    //Has a Player
    public partial class AddPlayer : Form
    {
        //Player object
        private Player player = new Player();
        //Flag to handle the form closing
        private bool closeForm;

        public AddPlayer()
        {
            //Windows initializations
            InitializeComponent();

            //Initializations
            InitializeGui();
        }

        //Constructor with Player argument
        public AddPlayer(Player player)
        {
            InitializeComponent();

            this.player = player;

            InitializeGui();
        }

        //Properties
        public Player PlayerData
        {
            get { return player; }

            set
            {
                if(value != null)
                {
                    player = value;
                    InitializeGui();
                }
            }
        }

     
        //Initialize GUI
        //If "Change"-button display customer's data
        private void InitializeGui()
        {
            textBoxName.Text = player.Name;
            textBoxWins.Text = player.RankingData.Wins.ToString();
            textBoxDraws.Text = player.RankingData.Draws.ToString();
            textBoxLosses.Text = player.RankingData.Losses.ToString();
            textBoxScore.Text = player.Score.ToString();          
        
            //Move cursor to recipe input box
            this.ActiveControl = textBoxName;
            closeForm = true;

        }

        //OK
        private void buttonOK_Click(object sender, EventArgs e)
        {
            ReadInput();
        }

        //Cancel
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Discard input?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //If Cancel
            if (result == DialogResult.OK)
            {
                closeForm = true;              
            }
        }

        //Read input
        private void ReadInput()
        {
            closeForm = true; // Default behavior is that the window is closed
            InputVerification verification = new InputVerification();
            int value = 0;

            if (verification.VerifyName(textBoxName.Text))
            {
                player.Name = textBoxName.Text.Trim();
            }
            else
            {
                MessageBox.Show("Wrong name format");
                closeForm = false;
            }

            // TODO: Either use the bool or remove it!
            bool ok = int.TryParse(textBoxWins.Text, out value);
            player.RankingData.Wins = value;

            ok = int.TryParse(textBoxDraws.Text, out value);
            player.RankingData.Draws = value;

            ok = int.TryParse(textBoxLosses.Text, out value);
            player.RankingData.Losses = value;

            double score;
            ok = double.TryParse(textBoxScore.Text, out score);
            player.Score = score;

        }

        //Only close form if user says yes to discard data when cancel is chosen
        private void AddPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm)
                e.Cancel = false;  //Close the contact form
            else
                e.Cancel = true; //Do not close (user has chonsen No)
        }

    }
}
