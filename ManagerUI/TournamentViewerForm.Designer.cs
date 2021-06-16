
namespace ManagerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.matchPairUpListBox = new System.Windows.Forms.ListBox();
            this.team1Name = new System.Windows.Forms.Label();
            this.team1ScoreLabel = new System.Windows.Forms.Label();
            this.team1ScoreValue = new System.Windows.Forms.TextBox();
            this.team2ScoreValue = new System.Windows.Forms.TextBox();
            this.team2ScoreLabel = new System.Windows.Forms.Label();
            this.team2Name = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Green;
            this.headerLabel.Location = new System.Drawing.Point(13, 13);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(241, 49);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI Emoji", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.Color.Green;
            this.tournamentName.Location = new System.Drawing.Point(239, 14);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(161, 49);
            this.tournamentName.TabIndex = 2;
            this.tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roundLabel.Location = new System.Drawing.Point(22, 105);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(94, 37);
            this.roundLabel.TabIndex = 3;
            this.roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(122, 105);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(204, 38);
            this.roundDropDown.TabIndex = 4;
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedOnlyCheckBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(123, 146);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(209, 41);
            this.unplayedOnlyCheckBox.TabIndex = 5;
            this.unplayedOnlyCheckBox.Text = "Unplayed Only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchPairUpListBox
            // 
            this.matchPairUpListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchPairUpListBox.FormattingEnabled = true;
            this.matchPairUpListBox.ItemHeight = 30;
            this.matchPairUpListBox.Location = new System.Drawing.Point(29, 239);
            this.matchPairUpListBox.Name = "matchPairUpListBox";
            this.matchPairUpListBox.Size = new System.Drawing.Size(297, 182);
            this.matchPairUpListBox.TabIndex = 6;
            // 
            // team1Name
            // 
            this.team1Name.AutoSize = true;
            this.team1Name.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.team1Name.Location = new System.Drawing.Point(361, 239);
            this.team1Name.Name = "team1Name";
            this.team1Name.Size = new System.Drawing.Size(135, 37);
            this.team1Name.TabIndex = 7;
            this.team1Name.Text = "<team 1>";
            // 
            // team1ScoreLabel
            // 
            this.team1ScoreLabel.AutoSize = true;
            this.team1ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1ScoreLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.team1ScoreLabel.Location = new System.Drawing.Point(361, 289);
            this.team1ScoreLabel.Name = "team1ScoreLabel";
            this.team1ScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.team1ScoreLabel.TabIndex = 8;
            this.team1ScoreLabel.Text = "Score";
            // 
            // team1ScoreValue
            // 
            this.team1ScoreValue.Location = new System.Drawing.Point(438, 292);
            this.team1ScoreValue.Name = "team1ScoreValue";
            this.team1ScoreValue.Size = new System.Drawing.Size(100, 35);
            this.team1ScoreValue.TabIndex = 9;
            // 
            // team2ScoreValue
            // 
            this.team2ScoreValue.Location = new System.Drawing.Point(438, 449);
            this.team2ScoreValue.Name = "team2ScoreValue";
            this.team2ScoreValue.Size = new System.Drawing.Size(100, 35);
            this.team2ScoreValue.TabIndex = 12;
            // 
            // team2ScoreLabel
            // 
            this.team2ScoreLabel.AutoSize = true;
            this.team2ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2ScoreLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.team2ScoreLabel.Location = new System.Drawing.Point(361, 446);
            this.team2ScoreLabel.Name = "team2ScoreLabel";
            this.team2ScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.team2ScoreLabel.TabIndex = 11;
            this.team2ScoreLabel.Text = "Score";
            // 
            // team2Name
            // 
            this.team2Name.AutoSize = true;
            this.team2Name.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.team2Name.Location = new System.Drawing.Point(361, 396);
            this.team2Name.Name = "team2Name";
            this.team2Name.Size = new System.Drawing.Size(135, 37);
            this.team2Name.TabIndex = 10;
            this.team2Name.Text = "<team 2>";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versusLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.versusLabel.Location = new System.Drawing.Point(442, 348);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(41, 37);
            this.versusLabel.TabIndex = 13;
            this.versusLabel.Text = "vs";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.ForeColor = System.Drawing.Color.Crimson;
            this.scoreButton.Location = new System.Drawing.Point(553, 361);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(134, 60);
            this.scoreButton.TabIndex = 14;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 610);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.team2ScoreValue);
            this.Controls.Add(this.team2ScoreLabel);
            this.Controls.Add(this.team2Name);
            this.Controls.Add(this.team1ScoreValue);
            this.Controls.Add(this.team1ScoreLabel);
            this.Controls.Add(this.team1Name);
            this.Controls.Add(this.matchPairUpListBox);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Green;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "<none>";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox matchPairUpListBox;
        private System.Windows.Forms.Label team1Name;
        private System.Windows.Forms.Label team1ScoreLabel;
        private System.Windows.Forms.TextBox team1ScoreValue;
        private System.Windows.Forms.TextBox team2ScoreValue;
        private System.Windows.Forms.Label team2ScoreLabel;
        private System.Windows.Forms.Label team2Name;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

