﻿namespace EvenTheTeams
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBoxPlayers = new System.Windows.Forms.GroupBox();
            this.buttonRandomizePlayers = new System.Windows.Forms.Button();
            this.labelHeadings = new System.Windows.Forms.Label();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.buttonAddToNext = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.groupBoxNext = new System.Windows.Forms.GroupBox();
            this.listBoxNextGame = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxPlayers.SuspendLayout();
            this.groupBoxNext.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(210, 38);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(165, 49);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save to file";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(9, 38);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(176, 49);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load from file";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBoxPlayers
            // 
            this.groupBoxPlayers.Controls.Add(this.buttonRandomizePlayers);
            this.groupBoxPlayers.Controls.Add(this.buttonSave);
            this.groupBoxPlayers.Controls.Add(this.labelHeadings);
            this.groupBoxPlayers.Controls.Add(this.buttonLoad);
            this.groupBoxPlayers.Controls.Add(this.listBoxPlayers);
            this.groupBoxPlayers.Controls.Add(this.buttonAddToNext);
            this.groupBoxPlayers.Controls.Add(this.buttonDelete);
            this.groupBoxPlayers.Controls.Add(this.buttonChange);
            this.groupBoxPlayers.Controls.Add(this.buttonAddPlayer);
            this.groupBoxPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPlayers.Location = new System.Drawing.Point(18, 12);
            this.groupBoxPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPlayers.Name = "groupBoxPlayers";
            this.groupBoxPlayers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxPlayers.Size = new System.Drawing.Size(998, 592);
            this.groupBoxPlayers.TabIndex = 1;
            this.groupBoxPlayers.TabStop = false;
            this.groupBoxPlayers.Text = "Players";
            // 
            // buttonRandomizePlayers
            // 
            this.buttonRandomizePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomizePlayers.Location = new System.Drawing.Point(708, 38);
            this.buttonRandomizePlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRandomizePlayers.Name = "buttonRandomizePlayers";
            this.buttonRandomizePlayers.Size = new System.Drawing.Size(280, 49);
            this.buttonRandomizePlayers.TabIndex = 9;
            this.buttonRandomizePlayers.Text = "Randomize players";
            this.buttonRandomizePlayers.UseVisualStyleBackColor = true;
            this.buttonRandomizePlayers.Click += new System.EventHandler(this.buttonRandomizePlayers_Click);
            // 
            // labelHeadings
            // 
            this.labelHeadings.AutoSize = true;
            this.labelHeadings.Location = new System.Drawing.Point(9, 111);
            this.labelHeadings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeadings.Name = "labelHeadings";
            this.labelHeadings.Size = new System.Drawing.Size(78, 29);
            this.labelHeadings.TabIndex = 8;
            this.labelHeadings.Text = "Name";
            this.labelHeadings.Click += new System.EventHandler(this.labelHeadings_Click);
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 22;
            this.listBoxPlayers.Location = new System.Drawing.Point(9, 151);
            this.listBoxPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.ScrollAlwaysVisible = true;
            this.listBoxPlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPlayers.Size = new System.Drawing.Size(978, 334);
            this.listBoxPlayers.TabIndex = 7;
            this.listBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayers_SelectedIndexChanged);
            // 
            // buttonAddToNext
            // 
            this.buttonAddToNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToNext.Location = new System.Drawing.Point(9, 523);
            this.buttonAddToNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddToNext.Name = "buttonAddToNext";
            this.buttonAddToNext.Size = new System.Drawing.Size(306, 49);
            this.buttonAddToNext.TabIndex = 6;
            this.buttonAddToNext.Text = "Add player to next game";
            this.buttonAddToNext.UseVisualStyleBackColor = true;
            this.buttonAddToNext.Click += new System.EventHandler(this.buttonAddToNext_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(736, 523);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(112, 49);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(876, 523);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(112, 49);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPlayer.Location = new System.Drawing.Point(537, 38);
            this.buttonAddPlayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(162, 49);
            this.buttonAddPlayer.TabIndex = 1;
            this.buttonAddPlayer.Text = "Add player";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // groupBoxNext
            // 
            this.groupBoxNext.Controls.Add(this.listBoxNextGame);
            this.groupBoxNext.Controls.Add(this.buttonRemove);
            this.groupBoxNext.Controls.Add(this.buttonCalculate);
            this.groupBoxNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNext.Location = new System.Drawing.Point(18, 614);
            this.groupBoxNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxNext.Name = "groupBoxNext";
            this.groupBoxNext.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxNext.Size = new System.Drawing.Size(998, 465);
            this.groupBoxNext.TabIndex = 2;
            this.groupBoxNext.TabStop = false;
            this.groupBoxNext.Text = "Next Game";
            // 
            // listBoxNextGame
            // 
            this.listBoxNextGame.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNextGame.FormattingEnabled = true;
            this.listBoxNextGame.ItemHeight = 22;
            this.listBoxNextGame.Location = new System.Drawing.Point(15, 34);
            this.listBoxNextGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxNextGame.Name = "listBoxNextGame";
            this.listBoxNextGame.Size = new System.Drawing.Size(972, 334);
            this.listBoxNextGame.TabIndex = 8;
            this.listBoxNextGame.SelectedIndexChanged += new System.EventHandler(this.listBoxNextGame_SelectedIndexChanged);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(648, 406);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(334, 49);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "Remove player from game";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(9, 408);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(212, 48);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate Teams";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1034, 1095);
            this.Controls.Add(this.groupBoxNext);
            this.Controls.Add(this.groupBoxPlayers);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Even the Teams";
            this.groupBoxPlayers.ResumeLayout(false);
            this.groupBoxPlayers.PerformLayout();
            this.groupBoxNext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupBoxPlayers;
        private System.Windows.Forms.Label labelHeadings;
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.Button buttonAddToNext;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.GroupBox groupBoxNext;
        private System.Windows.Forms.ListBox listBoxNextGame;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonRandomizePlayers;
    }
}

