namespace EvenTheTeams
{
    partial class AddPlayer
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
            this.groupBoxAddPlayer = new System.Windows.Forms.GroupBox();
            this.checkBoxRunner = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxGoals = new System.Windows.Forms.TextBox();
            this.textBoxDraws = new System.Windows.Forms.TextBox();
            this.textBoxLosses = new System.Windows.Forms.TextBox();
            this.textBoxWins = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelGoals = new System.Windows.Forms.Label();
            this.labelDraws = new System.Windows.Forms.Label();
            this.labelLoasses = new System.Windows.Forms.Label();
            this.labelWins = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxAddPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddPlayer
            // 
            this.groupBoxAddPlayer.Controls.Add(this.checkBoxRunner);
            this.groupBoxAddPlayer.Controls.Add(this.label1);
            this.groupBoxAddPlayer.Controls.Add(this.buttonCancel);
            this.groupBoxAddPlayer.Controls.Add(this.buttonOK);
            this.groupBoxAddPlayer.Controls.Add(this.textBoxGoals);
            this.groupBoxAddPlayer.Controls.Add(this.textBoxDraws);
            this.groupBoxAddPlayer.Controls.Add(this.textBoxLosses);
            this.groupBoxAddPlayer.Controls.Add(this.textBoxWins);
            this.groupBoxAddPlayer.Controls.Add(this.textBoxName);
            this.groupBoxAddPlayer.Controls.Add(this.labelGoals);
            this.groupBoxAddPlayer.Controls.Add(this.labelDraws);
            this.groupBoxAddPlayer.Controls.Add(this.labelLoasses);
            this.groupBoxAddPlayer.Controls.Add(this.labelWins);
            this.groupBoxAddPlayer.Controls.Add(this.labelName);
            this.groupBoxAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddPlayer.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddPlayer.Name = "groupBoxAddPlayer";
            this.groupBoxAddPlayer.Size = new System.Drawing.Size(361, 354);
            this.groupBoxAddPlayer.TabIndex = 0;
            this.groupBoxAddPlayer.TabStop = false;
            this.groupBoxAddPlayer.Text = "Add player";
            this.groupBoxAddPlayer.Enter += new System.EventHandler(this.groupBoxAddPlayer_Enter);
            // 
            // checkBoxRunner
            // 
            this.checkBoxRunner.AutoSize = true;
            this.checkBoxRunner.Location = new System.Drawing.Point(298, 260);
            this.checkBoxRunner.Name = "checkBoxRunner";
            this.checkBoxRunner.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRunner.TabIndex = 21;
            this.checkBoxRunner.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Is a runner";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(186, 303);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 35);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(53, 303);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(111, 35);
            this.buttonOK.TabIndex = 14;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxGoals
            // 
            this.textBoxGoals.Location = new System.Drawing.Point(78, 211);
            this.textBoxGoals.Name = "textBoxGoals";
            this.textBoxGoals.Size = new System.Drawing.Size(235, 29);
            this.textBoxGoals.TabIndex = 13;
            // 
            // textBoxDraws
            // 
            this.textBoxDraws.Location = new System.Drawing.Point(78, 168);
            this.textBoxDraws.Name = "textBoxDraws";
            this.textBoxDraws.Size = new System.Drawing.Size(235, 29);
            this.textBoxDraws.TabIndex = 12;
            // 
            // textBoxLosses
            // 
            this.textBoxLosses.Location = new System.Drawing.Point(78, 128);
            this.textBoxLosses.Name = "textBoxLosses";
            this.textBoxLosses.Size = new System.Drawing.Size(235, 29);
            this.textBoxLosses.TabIndex = 11;
            // 
            // textBoxWins
            // 
            this.textBoxWins.Location = new System.Drawing.Point(78, 88);
            this.textBoxWins.Name = "textBoxWins";
            this.textBoxWins.Size = new System.Drawing.Size(235, 29);
            this.textBoxWins.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(78, 49);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(235, 29);
            this.textBoxName.TabIndex = 7;
            // 
            // labelGoals
            // 
            this.labelGoals.AutoSize = true;
            this.labelGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoals.Location = new System.Drawing.Point(17, 216);
            this.labelGoals.Name = "labelGoals";
            this.labelGoals.Size = new System.Drawing.Size(48, 18);
            this.labelGoals.TabIndex = 6;
            this.labelGoals.Text = "Goals";
            // 
            // labelDraws
            // 
            this.labelDraws.AutoSize = true;
            this.labelDraws.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDraws.Location = new System.Drawing.Point(17, 174);
            this.labelDraws.Name = "labelDraws";
            this.labelDraws.Size = new System.Drawing.Size(51, 18);
            this.labelDraws.TabIndex = 5;
            this.labelDraws.Text = "Draws";
            // 
            // labelLoasses
            // 
            this.labelLoasses.AutoSize = true;
            this.labelLoasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoasses.Location = new System.Drawing.Point(17, 130);
            this.labelLoasses.Name = "labelLoasses";
            this.labelLoasses.Size = new System.Drawing.Size(57, 18);
            this.labelLoasses.TabIndex = 4;
            this.labelLoasses.Text = "Losses";
            // 
            // labelWins
            // 
            this.labelWins.AutoSize = true;
            this.labelWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWins.Location = new System.Drawing.Point(17, 90);
            this.labelWins.Name = "labelWins";
            this.labelWins.Size = new System.Drawing.Size(42, 18);
            this.labelWins.TabIndex = 3;
            this.labelWins.Text = "Wins";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(17, 51);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(48, 18);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 380);
            this.Controls.Add(this.groupBoxAddPlayer);
            this.Name = "AddPlayer";
            this.Text = "AddPlayer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPlayer_FormClosing);
            this.groupBoxAddPlayer.ResumeLayout(false);
            this.groupBoxAddPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddPlayer;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxGoals;
        private System.Windows.Forms.TextBox textBoxDraws;
        private System.Windows.Forms.TextBox textBoxLosses;
        private System.Windows.Forms.TextBox textBoxWins;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelGoals;
        private System.Windows.Forms.Label labelDraws;
        private System.Windows.Forms.Label labelLoasses;
        private System.Windows.Forms.Label labelWins;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.CheckBox checkBoxRunner;
        private System.Windows.Forms.Label label1;
    }
}