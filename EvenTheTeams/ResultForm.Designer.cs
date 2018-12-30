namespace EvenTheTeams
{
    partial class ResultForm
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
            this.labelTeam1 = new System.Windows.Forms.Label();
            this.labelTeam2 = new System.Windows.Forms.Label();
            this.listBoxTeam1 = new System.Windows.Forms.ListBox();
            this.listBoxTeam2 = new System.Windows.Forms.ListBox();
            this.buttonMoveTo2 = new System.Windows.Forms.Button();
            this.buttonMoveTo1 = new System.Windows.Forms.Button();
            this.labelTextPoints1 = new System.Windows.Forms.Label();
            this.labelTextPoints2 = new System.Windows.Forms.Label();
            this.labelPointsTeam1 = new System.Windows.Forms.Label();
            this.labelPointsTeam2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTeam1
            // 
            this.labelTeam1.AutoSize = true;
            this.labelTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelTeam1.Location = new System.Drawing.Point(139, 75);
            this.labelTeam1.Name = "labelTeam1";
            this.labelTeam1.Size = new System.Drawing.Size(113, 36);
            this.labelTeam1.TabIndex = 0;
            this.labelTeam1.Text = "Team 1";
            // 
            // labelTeam2
            // 
            this.labelTeam2.AutoSize = true;
            this.labelTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelTeam2.Location = new System.Drawing.Point(605, 75);
            this.labelTeam2.Name = "labelTeam2";
            this.labelTeam2.Size = new System.Drawing.Size(113, 36);
            this.labelTeam2.TabIndex = 1;
            this.labelTeam2.Text = "Team 2";
            // 
            // listBoxTeam1
            // 
            this.listBoxTeam1.FormattingEnabled = true;
            this.listBoxTeam1.ItemHeight = 25;
            this.listBoxTeam1.Location = new System.Drawing.Point(52, 139);
            this.listBoxTeam1.Name = "listBoxTeam1";
            this.listBoxTeam1.Size = new System.Drawing.Size(337, 554);
            this.listBoxTeam1.TabIndex = 2;
            this.listBoxTeam1.SelectedIndexChanged += new System.EventHandler(this.listBoxTeam1_SelectedIndexChanged);
            // 
            // listBoxTeam2
            // 
            this.listBoxTeam2.FormattingEnabled = true;
            this.listBoxTeam2.ItemHeight = 25;
            this.listBoxTeam2.Location = new System.Drawing.Point(487, 139);
            this.listBoxTeam2.Name = "listBoxTeam2";
            this.listBoxTeam2.Size = new System.Drawing.Size(337, 554);
            this.listBoxTeam2.TabIndex = 3;
            this.listBoxTeam2.SelectedIndexChanged += new System.EventHandler(this.listBoxTeam2_SelectedIndexChanged);
            // 
            // buttonMoveTo2
            // 
            this.buttonMoveTo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveTo2.Location = new System.Drawing.Point(405, 306);
            this.buttonMoveTo2.Name = "buttonMoveTo2";
            this.buttonMoveTo2.Size = new System.Drawing.Size(65, 66);
            this.buttonMoveTo2.TabIndex = 4;
            this.buttonMoveTo2.Text = ">";
            this.buttonMoveTo2.UseVisualStyleBackColor = true;
            this.buttonMoveTo2.Click += new System.EventHandler(this.buttonMoveTo2_Click);
            // 
            // buttonMoveTo1
            // 
            this.buttonMoveTo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveTo1.Location = new System.Drawing.Point(405, 410);
            this.buttonMoveTo1.Name = "buttonMoveTo1";
            this.buttonMoveTo1.Size = new System.Drawing.Size(65, 66);
            this.buttonMoveTo1.TabIndex = 5;
            this.buttonMoveTo1.Text = "<";
            this.buttonMoveTo1.UseVisualStyleBackColor = true;
            this.buttonMoveTo1.Click += new System.EventHandler(this.buttonMoveTo1_Click);
            // 
            // labelTextPoints1
            // 
            this.labelTextPoints1.AutoSize = true;
            this.labelTextPoints1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelTextPoints1.Location = new System.Drawing.Point(46, 715);
            this.labelTextPoints1.Name = "labelTextPoints1";
            this.labelTextPoints1.Size = new System.Drawing.Size(268, 36);
            this.labelTextPoints1.TabIndex = 6;
            this.labelTextPoints1.Text = "Sum points team 1:";
            // 
            // labelTextPoints2
            // 
            this.labelTextPoints2.AutoSize = true;
            this.labelTextPoints2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelTextPoints2.Location = new System.Drawing.Point(481, 715);
            this.labelTextPoints2.Name = "labelTextPoints2";
            this.labelTextPoints2.Size = new System.Drawing.Size(276, 36);
            this.labelTextPoints2.TabIndex = 7;
            this.labelTextPoints2.Text = "Sum points team 2: ";
            // 
            // labelPointsTeam1
            // 
            this.labelPointsTeam1.AutoSize = true;
            this.labelPointsTeam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelPointsTeam1.Location = new System.Drawing.Point(357, 715);
            this.labelPointsTeam1.Name = "labelPointsTeam1";
            this.labelPointsTeam1.Size = new System.Drawing.Size(32, 36);
            this.labelPointsTeam1.TabIndex = 8;
            this.labelPointsTeam1.Text = "0";
            // 
            // labelPointsTeam2
            // 
            this.labelPointsTeam2.AutoSize = true;
            this.labelPointsTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.labelPointsTeam2.Location = new System.Drawing.Point(792, 715);
            this.labelPointsTeam2.Name = "labelPointsTeam2";
            this.labelPointsTeam2.Size = new System.Drawing.Size(32, 36);
            this.labelPointsTeam2.TabIndex = 9;
            this.labelPointsTeam2.Text = "0";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 832);
            this.Controls.Add(this.labelPointsTeam2);
            this.Controls.Add(this.labelPointsTeam1);
            this.Controls.Add(this.labelTextPoints2);
            this.Controls.Add(this.labelTextPoints1);
            this.Controls.Add(this.buttonMoveTo1);
            this.Controls.Add(this.buttonMoveTo2);
            this.Controls.Add(this.listBoxTeam2);
            this.Controls.Add(this.listBoxTeam1);
            this.Controls.Add(this.labelTeam2);
            this.Controls.Add(this.labelTeam1);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTeam1;
        private System.Windows.Forms.Label labelTeam2;
        private System.Windows.Forms.ListBox listBoxTeam1;
        private System.Windows.Forms.ListBox listBoxTeam2;
        private System.Windows.Forms.Button buttonMoveTo2;
        private System.Windows.Forms.Button buttonMoveTo1;
        private System.Windows.Forms.Label labelTextPoints1;
        private System.Windows.Forms.Label labelTextPoints2;
        private System.Windows.Forms.Label labelPointsTeam1;
        private System.Windows.Forms.Label labelPointsTeam2;
    }
}