﻿//Lena Lindblad
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
        }

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

        private void buttonChange_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddToNext_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int index = listBoxNextGame.SelectedIndex;
            if (index >= 0)
            {
                //Delete not done
                //
                UpdateGUI();
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            ResultForm result = new ResultForm();
            result.ShowDialog();
        }

        //Clear listbox and print players
        private void UpdateGUI()
        {
            listBoxPlayers.Items.Clear();
            listBoxPlayers.Items.AddRange(playerMgr.GetPlayersInfo());
        }

        //Get index for highlighted row
        private void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
            {
                int index = listBoxPlayers.SelectedIndex;
            }   
    }
}