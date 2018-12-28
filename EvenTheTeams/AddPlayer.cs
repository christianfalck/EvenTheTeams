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
            textBoxGoals.Text = player.RankingData.Goals.ToString();

            

            
            //Move cursor to recipe input box
            this.ActiveControl = textBoxName;
            closeForm = true;

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ReadInput();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Discard input?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //If Cancel
            if (result == DialogResult.OK)
            {
                closeForm = true;              
            }
        }

        private void ReadInput()
        {
            int value = 0;

            player.Name = textBoxName.Text.Trim();
            bool ok = int.TryParse(textBoxWins.Text, out value);
            player.RankingData.Wins = value;
            ok = int.TryParse(textBoxGoals.Text, out value);
            player.RankingData.Draws = value;
            ok = int.TryParse(textBoxLosses.Text, out value);
            player.RankingData.Losses = value;
        }

        //Only close form if user says yes to discard data when cancel is chosen
        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeForm)
                e.Cancel = false;  //Close the contact form
            else
                e.Cancel = true; //Do not close (user has chonsen No)
        }
    }
}
