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
    public partial class MainForm : Form
    {
        //Instace variables
        private PlayerManager playerMgr = new PlayerManager();
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        //Display headings
        private void InitializeGUI()
        {
            labelHeadings.Text = playerMgr.GetHeading();
            buttonAddToNext.Enabled = false;
            buttonChange.Enabled = false;
            buttonDelete.Enabled = false;
            buttonRemove.Enabled = false;
            buttonShowContact.Enabled = false;
            buttonCalculate.Enabled = false;
        }

        //Open add player form and save or discard changes
        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayer frmPlayer = new AddPlayer();
            if (frmPlayer.ShowDialog() == DialogResult.OK)
            {
                Player playerObj = new Player(frmPlayer.PlayerData);
                playerMgr.AddPlayer(playerObj);
                UpdateGUI();
            }
        }

        //Open add player form and save or discard changes
        private void buttonChange_Click(object sender, EventArgs e)
        {
            int index = listBoxPlayers.SelectedIndex;
            if (index >= 0)
            {
                AddPlayer frmPlayer = new AddPlayer(playerMgr.GetPlayer(index));
                if (frmPlayer.ShowDialog() == DialogResult.OK)
                {
                    Player playerObj = new Player(frmPlayer.PlayerData);
                    bool ok = playerMgr.ChangePlayer(playerObj, index);
                    UpdateGUI();
                }
            }
        }

        //Delete selected player form the list
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxPlayers.SelectedIndex;
            if (index >= 0)
            {
                {
                    playerMgr.DeletePlayer(index);
                    UpdateGUI();
                }
                UpdateGUI();
            }
        }

        //Add selected player to next game 
        private void buttonAddToNext_Click(object sender, EventArgs e)
        {
            int index = listBoxPlayers.SelectedIndex;
            if (index >= 0)
            {
                {
                    playerMgr.AddNextPlayer(index);
                    UpdateNextGUI();
                }
            }
        }

        //Remove selected player from next game listBox
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int index = listBoxNextGame.SelectedIndex;
            if (index >= 0)
            {
                {
                    playerMgr.DeleteNextPlayer(index);
                    UpdateNextGUI();
                }
                UpdateNextGUI();
            }
        }

        //Calculate teams and show reslut in ResultForm
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            ResultForm result;
            if (playerMgr.GetNextGamePlayers().Count() > 0)
            {
                result = new ResultForm(playerMgr.GetNextGamePlayers());
            }
            else
            {
                result = new ResultForm(); // randomizing players if there are none
            }
            result.ShowDialog();
        }

        //Clear listbox and print players
        private void UpdateGUI()
        {
            listBoxPlayers.Items.Clear();
            listBoxPlayers.Items.AddRange(playerMgr.GetPlayersInfo());
            buttonAddToNext.Enabled = false;
            buttonChange.Enabled = false;
            buttonDelete.Enabled = false;
            buttonShowContact.Enabled = false;
        }

        //Clear listbox and print players, enable Calculate if 10 or more players
        private void UpdateNextGUI()
        {
            listBoxNextGame.Items.Clear();
            listBoxNextGame.Items.AddRange(playerMgr.GetNextPlayersInfo());
            buttonRemove.Enabled = false;
            if (playerMgr.EnoughPlayers())
                buttonCalculate.Enabled = true;
            else buttonCalculate.Enabled = false;
        }

        //Get index for highlighted row
        private void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxPlayers.SelectedIndex;
            buttonAddToNext.Enabled = true;
            buttonChange.Enabled = true;
            buttonDelete.Enabled = true;
            buttonShowContact.Enabled = true;
        }

        // Open a file selection window and load players from the selected file
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            List<Player> players;
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                players = FileHandler.OpenFile(file);
                foreach (Player player in players)
                {
                    playerMgr.AddPlayer(player);
                }
            }
            UpdateGUI();
        }

        // Saving all available players in a file players.txt
        private void buttonSave_Click(object sender, EventArgs e)
        {
            FileHandler.SaveFile(playerMgr.GetAllPlayers(), "players.txt");
        }

        // For testing purposes, we've added a function to add a number of random players
        private void buttonRandomizePlayers_Click(object sender, EventArgs e)
        {
            List<Player> players = FileHandler.RandomizePlayers(10);
            foreach (Player player in players)
            {
                playerMgr.AddPlayer(player);
            }
            UpdateGUI();
        }

        //Enalbe Remove button if a player is selected
        private void listBoxNextGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemove.Enabled = true;
        }

        //Show contact data in a message bos for selected player
        private void buttonShowContact_Click(object sender, EventArgs e)
        {
            int index = listBoxPlayers.SelectedIndex;
            if (index >= 0)
            {
                Player player = playerMgr.GetPlayer(index);
                string strOut = "phone: " + player.ContactData.Phone + "  email: " + player.ContactData.Email;
                MessageBox.Show(strOut);
            }
        }
    }
}
