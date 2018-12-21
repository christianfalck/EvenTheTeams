namespace EvenTheTeams
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
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.groupBoxPlayers = new System.Windows.Forms.GroupBox();
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
            this.groupBoxFile.SuspendLayout();
            this.groupBoxPlayers.SuspendLayout();
            this.groupBoxNext.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.buttonSave);
            this.groupBoxFile.Controls.Add(this.buttonLoad);
            this.groupBoxFile.Controls.Add(this.labelPath);
            this.groupBoxFile.Controls.Add(this.textBoxPath);
            this.groupBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFile.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(455, 97);
            this.groupBoxFile.TabIndex = 0;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "File handling";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(281, 59);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(110, 32);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save to file";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(316, 22);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 34);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.Location = new System.Drawing.Point(6, 30);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(59, 16);
            this.labelPath.TabIndex = 1;
            this.labelPath.Text = "File path";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(71, 30);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(239, 26);
            this.textBoxPath.TabIndex = 0;
            // 
            // groupBoxPlayers
            // 
            this.groupBoxPlayers.Controls.Add(this.labelHeadings);
            this.groupBoxPlayers.Controls.Add(this.listBoxPlayers);
            this.groupBoxPlayers.Controls.Add(this.buttonAddToNext);
            this.groupBoxPlayers.Controls.Add(this.buttonDelete);
            this.groupBoxPlayers.Controls.Add(this.buttonChange);
            this.groupBoxPlayers.Controls.Add(this.buttonAddPlayer);
            this.groupBoxPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPlayers.Location = new System.Drawing.Point(12, 115);
            this.groupBoxPlayers.Name = "groupBoxPlayers";
            this.groupBoxPlayers.Size = new System.Drawing.Size(455, 267);
            this.groupBoxPlayers.TabIndex = 1;
            this.groupBoxPlayers.TabStop = false;
            this.groupBoxPlayers.Text = "Players";
            // 
            // labelHeadings
            // 
            this.labelHeadings.AutoSize = true;
            this.labelHeadings.Location = new System.Drawing.Point(24, 45);
            this.labelHeadings.Name = "labelHeadings";
            this.labelHeadings.Size = new System.Drawing.Size(51, 20);
            this.labelHeadings.TabIndex = 8;
            this.labelHeadings.Text = "Name";
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 20;
            this.listBoxPlayers.Location = new System.Drawing.Point(27, 62);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.ScrollAlwaysVisible = true;
            this.listBoxPlayers.Size = new System.Drawing.Size(385, 144);
            this.listBoxPlayers.TabIndex = 7;
            this.listBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayers_SelectedIndexChanged);
            // 
            // buttonAddToNext
            // 
            this.buttonAddToNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddToNext.Location = new System.Drawing.Point(208, 228);
            this.buttonAddToNext.Name = "buttonAddToNext";
            this.buttonAddToNext.Size = new System.Drawing.Size(204, 33);
            this.buttonAddToNext.TabIndex = 6;
            this.buttonAddToNext.Text = "Add player to next game";
            this.buttonAddToNext.UseVisualStyleBackColor = true;
            this.buttonAddToNext.Click += new System.EventHandler(this.buttonAddToNext_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(122, 228);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 33);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.Location = new System.Drawing.Point(27, 228);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 33);
            this.buttonChange.TabIndex = 4;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPlayer.Location = new System.Drawing.Point(304, 19);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(108, 27);
            this.buttonAddPlayer.TabIndex = 3;
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
            this.groupBoxNext.Location = new System.Drawing.Point(12, 388);
            this.groupBoxNext.Name = "groupBoxNext";
            this.groupBoxNext.Size = new System.Drawing.Size(455, 174);
            this.groupBoxNext.TabIndex = 2;
            this.groupBoxNext.TabStop = false;
            this.groupBoxNext.Text = "Next Game";
            // 
            // listBoxNextGame
            // 
            this.listBoxNextGame.FormattingEnabled = true;
            this.listBoxNextGame.ItemHeight = 20;
            this.listBoxNextGame.Location = new System.Drawing.Point(27, 22);
            this.listBoxNextGame.Name = "listBoxNextGame";
            this.listBoxNextGame.Size = new System.Drawing.Size(236, 104);
            this.listBoxNextGame.TabIndex = 8;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.Location = new System.Drawing.Point(27, 135);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(223, 33);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "Remove player from game";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(271, 61);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(141, 31);
            this.buttonCalculate.TabIndex = 3;
            this.buttonCalculate.Text = "Calculate Teams";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 564);
            this.Controls.Add(this.groupBoxNext);
            this.Controls.Add(this.groupBoxPlayers);
            this.Controls.Add(this.groupBoxFile);
            this.Name = "MainForm";
            this.Text = "Even the Teams";
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
            this.groupBoxPlayers.ResumeLayout(false);
            this.groupBoxPlayers.PerformLayout();
            this.groupBoxNext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPath;
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
    }
}

