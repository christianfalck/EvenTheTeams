//Lena Lindblad
//HT2018-DA204B-88221
//Project 

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
                if (value != null)
                {
                    player = value;
                    InitializeGui();
                }
            }
        }


        //Initialize GUI
        //If "Change"-button display players's data
        private void InitializeGui()
        {
            textBoxName.Text = player.Name;
            textBoxEmail.Text = player.ContactData.Email;
            textBoxPhone.Text = player.ContactData.Phone;
            textBoxWins.Text = player.RankingData.Wins.ToString();
            textBoxDraws.Text = player.RankingData.Draws.ToString();
            textBoxLosses.Text = player.RankingData.Losses.ToString();
            textBoxGoals.Text = player.RankingData.Goals.ToString();
            

            //Move cursor to name input 
            this.ActiveControl = textBoxName;
            closeForm = true;

        }

        //OK button, read input data
        private void buttonOK_Click(object sender, EventArgs e)
        {
            ReadInput();
        }

        //Cancel
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            closeForm = false;
            var result = MessageBox.Show("Discard input?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //If Cancel
            if (result == DialogResult.OK)
            {
                closeForm = true;
            }
        }

        //Read input, only read next input if above is ok
        private void ReadInput()
        {
            closeForm = true; // Default behavior is that the window is closing
            InputVerification verification = new InputVerification();
            int value = 0;

            if (verification.VerifyName(textBoxName.Text))
            {
                player.Name = textBoxName.Text.Trim();

                //If name ok read ranking
                if (int.TryParse(textBoxWins.Text, out value))
                {
                    player.RankingData.Wins = value;

                    //If wins ok read draws
                    if (int.TryParse(textBoxDraws.Text, out value))
                    {
                        player.RankingData.Draws = value;

                        //If draws ok read losses
                        if (int.TryParse(textBoxLosses.Text, out value))
                        {
                            player.RankingData.Losses = value;

                            //If losses ok read goals
                            if (int.TryParse(textBoxGoals.Text, out value))
                                player.RankingData.Goals = value;
                            else
                            {
                                MessageBox.Show("goals must be a number");
                                closeForm = false;
                            }
                        }

                        else
                        {
                            MessageBox.Show("losses must be a number");
                            closeForm = false;
                        }
                    }

                    else
                    {
                        MessageBox.Show("draws must be a number");
                        closeForm = false;
                    }
                }
                else
                {
                    MessageBox.Show("wins must be a number");
                    closeForm = false;
                }
            }
            else
            {
                MessageBox.Show("Wrong name format");
                closeForm = false;
            }

            //Check optional email

            if (textBoxEmail.Text != string.Empty)

                if (verification.VerifyEmail(textBoxEmail.Text))
                {
                    player.ContactData.Email = textBoxEmail.Text.Trim();

                }
                else
                {
                    MessageBox.Show("Wrong email format");
                    closeForm = false;
                }
            //Check phone
            if (textBoxPhone.Text != string.Empty)
            {
                if (verification.VerifyPhoneNumber(textBoxPhone.Text))
                {
                    player.ContactData.Phone = textBoxPhone.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Wrong phone format");
                    closeForm = false;
                }
            }
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
