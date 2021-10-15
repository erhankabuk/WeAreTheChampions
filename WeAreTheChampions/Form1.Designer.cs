
namespace WeAreTheChampions
{
    partial class Form1
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabMatchSchedule = new System.Windows.Forms.TabPage();
            this.btnEditMatch = new System.Windows.Forms.Button();
            this.btnDeleteMatch = new System.Windows.Forms.Button();
            this.btnAddNewMatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.tabTeams = new System.Windows.Forms.TabPage();
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.btnAddTeamColor = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.btnAddNewPlayer = new System.Windows.Forms.Button();
            this.cmbTeamList = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.tabColors = new System.Windows.Forms.TabPage();
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTeamName = new System.Windows.Forms.ComboBox();
            this.btnAddNewTeam = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabMatchSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            this.tabTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            this.tabPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.tabColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabMatchSchedule);
            this.tabs.Controls.Add(this.tabTeams);
            this.tabs.Controls.Add(this.tabPlayers);
            this.tabs.Controls.Add(this.tabColors);
            this.tabs.Location = new System.Drawing.Point(13, 14);
            this.tabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(900, 531);
            this.tabs.TabIndex = 0;
            this.tabs.Tag = "";
            // 
            // tabMatchSchedule
            // 
            this.tabMatchSchedule.BackColor = System.Drawing.Color.LightGray;
            this.tabMatchSchedule.Controls.Add(this.btnEditMatch);
            this.tabMatchSchedule.Controls.Add(this.btnDeleteMatch);
            this.tabMatchSchedule.Controls.Add(this.btnAddNewMatch);
            this.tabMatchSchedule.Controls.Add(this.label1);
            this.tabMatchSchedule.Controls.Add(this.dgvMatches);
            this.tabMatchSchedule.Location = new System.Drawing.Point(4, 34);
            this.tabMatchSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMatchSchedule.Name = "tabMatchSchedule";
            this.tabMatchSchedule.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMatchSchedule.Size = new System.Drawing.Size(886, 493);
            this.tabMatchSchedule.TabIndex = 0;
            this.tabMatchSchedule.Text = "Match Schedule";
            // 
            // btnEditMatch
            // 
            this.btnEditMatch.Location = new System.Drawing.Point(300, 431);
            this.btnEditMatch.Name = "btnEditMatch";
            this.btnEditMatch.Size = new System.Drawing.Size(286, 55);
            this.btnEditMatch.TabIndex = 4;
            this.btnEditMatch.Text = "Edit Match";
            this.btnEditMatch.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMatch
            // 
            this.btnDeleteMatch.Location = new System.Drawing.Point(592, 431);
            this.btnDeleteMatch.Name = "btnDeleteMatch";
            this.btnDeleteMatch.Size = new System.Drawing.Size(286, 55);
            this.btnDeleteMatch.TabIndex = 3;
            this.btnDeleteMatch.Text = "Delete Match";
            this.btnDeleteMatch.UseVisualStyleBackColor = true;
            // 
            // btnAddNewMatch
            // 
            this.btnAddNewMatch.Location = new System.Drawing.Point(8, 431);
            this.btnAddNewMatch.Name = "btnAddNewMatch";
            this.btnAddNewMatch.Size = new System.Drawing.Size(286, 55);
            this.btnAddNewMatch.TabIndex = 2;
            this.btnAddNewMatch.Text = "Add New Match";
            this.btnAddNewMatch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matches";
            // 
            // dgvMatches
            // 
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Location = new System.Drawing.Point(8, 71);
            this.dgvMatches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.RowHeadersWidth = 51;
            this.dgvMatches.RowTemplate.Height = 24;
            this.dgvMatches.Size = new System.Drawing.Size(870, 352);
            this.dgvMatches.TabIndex = 0;
            // 
            // tabTeams
            // 
            this.tabTeams.BackColor = System.Drawing.Color.LightGray;
            this.tabTeams.Controls.Add(this.btnAddNewTeam);
            this.tabTeams.Controls.Add(this.cmbTeamName);
            this.tabTeams.Controls.Add(this.dgvTeams);
            this.tabTeams.Controls.Add(this.btnAddTeamColor);
            this.tabTeams.Controls.Add(this.btnAddPlayer);
            this.tabTeams.Controls.Add(this.label6);
            this.tabTeams.Location = new System.Drawing.Point(4, 34);
            this.tabTeams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeams.Name = "tabTeams";
            this.tabTeams.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeams.Size = new System.Drawing.Size(892, 493);
            this.tabTeams.TabIndex = 1;
            this.tabTeams.Text = "Teams";
            // 
            // dgvTeams
            // 
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Location = new System.Drawing.Point(12, 146);
            this.dgvTeams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.RowHeadersWidth = 51;
            this.dgvTeams.RowTemplate.Height = 24;
            this.dgvTeams.Size = new System.Drawing.Size(870, 342);
            this.dgvTeams.TabIndex = 6;
            // 
            // btnAddTeamColor
            // 
            this.btnAddTeamColor.Location = new System.Drawing.Point(596, 83);
            this.btnAddTeamColor.Name = "btnAddTeamColor";
            this.btnAddTeamColor.Size = new System.Drawing.Size(286, 55);
            this.btnAddTeamColor.TabIndex = 5;
            this.btnAddTeamColor.Text = "Add Team Color";
            this.btnAddTeamColor.UseVisualStyleBackColor = true;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(304, 83);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(286, 55);
            this.btnAddPlayer.TabIndex = 4;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Team Name :";
            // 
            // tabPlayers
            // 
            this.tabPlayers.BackColor = System.Drawing.Color.LightGray;
            this.tabPlayers.Controls.Add(this.btnAddNewPlayer);
            this.tabPlayers.Controls.Add(this.cmbTeamList);
            this.tabPlayers.Controls.Add(this.label8);
            this.tabPlayers.Controls.Add(this.txtPlayerName);
            this.tabPlayers.Controls.Add(this.label7);
            this.tabPlayers.Controls.Add(this.dgvPlayers);
            this.tabPlayers.Location = new System.Drawing.Point(4, 34);
            this.tabPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPlayers.Size = new System.Drawing.Size(892, 493);
            this.tabPlayers.TabIndex = 2;
            this.tabPlayers.Text = "Players";
            // 
            // btnAddNewPlayer
            // 
            this.btnAddNewPlayer.Location = new System.Drawing.Point(12, 138);
            this.btnAddNewPlayer.Name = "btnAddNewPlayer";
            this.btnAddNewPlayer.Size = new System.Drawing.Size(286, 55);
            this.btnAddNewPlayer.TabIndex = 6;
            this.btnAddNewPlayer.Text = "Add New Player";
            this.btnAddNewPlayer.UseVisualStyleBackColor = true;
            this.btnAddNewPlayer.Click += new System.EventHandler(this.btnAddNewPlayer_Click);
            // 
            // cmbTeamList
            // 
            this.cmbTeamList.FormattingEnabled = true;
            this.cmbTeamList.Location = new System.Drawing.Point(87, 86);
            this.cmbTeamList.Name = "cmbTeamList";
            this.cmbTeamList.Size = new System.Drawing.Size(203, 33);
            this.cmbTeamList.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Team :";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(148, 33);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(142, 30);
            this.txtPlayerName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Player Name :";
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Location = new System.Drawing.Point(8, 214);
            this.dgvPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.RowHeadersWidth = 51;
            this.dgvPlayers.RowTemplate.Height = 24;
            this.dgvPlayers.Size = new System.Drawing.Size(870, 269);
            this.dgvPlayers.TabIndex = 1;
            // 
            // tabColors
            // 
            this.tabColors.BackColor = System.Drawing.Color.LightGray;
            this.tabColors.Controls.Add(this.dgvColors);
            this.tabColors.Controls.Add(this.btnAddColor);
            this.tabColors.Controls.Add(this.nudGreen);
            this.tabColors.Controls.Add(this.nudBlue);
            this.tabColors.Controls.Add(this.nudRed);
            this.tabColors.Controls.Add(this.label5);
            this.tabColors.Controls.Add(this.label4);
            this.tabColors.Controls.Add(this.label3);
            this.tabColors.Controls.Add(this.txtColorName);
            this.tabColors.Controls.Add(this.label2);
            this.tabColors.Location = new System.Drawing.Point(4, 34);
            this.tabColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabColors.Name = "tabColors";
            this.tabColors.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabColors.Size = new System.Drawing.Size(892, 493);
            this.tabColors.TabIndex = 3;
            this.tabColors.Text = "Colors";
            // 
            // dgvColors
            // 
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Location = new System.Drawing.Point(8, 306);
            this.dgvColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.RowHeadersWidth = 51;
            this.dgvColors.RowTemplate.Height = 24;
            this.dgvColors.Size = new System.Drawing.Size(870, 177);
            this.dgvColors.TabIndex = 9;
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(7, 243);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(286, 55);
            this.btnAddColor.TabIndex = 8;
            this.btnAddColor.Text = "Add New Color";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // nudGreen
            // 
            this.nudGreen.Location = new System.Drawing.Point(87, 140);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(120, 30);
            this.nudGreen.TabIndex = 7;
            // 
            // nudBlue
            // 
            this.nudBlue.Location = new System.Drawing.Point(86, 193);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(120, 30);
            this.nudBlue.TabIndex = 6;
            // 
            // nudRed
            // 
            this.nudRed.Location = new System.Drawing.Point(87, 87);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(120, 30);
            this.nudRed.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Red     :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Green :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue    :";
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(135, 33);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(142, 30);
            this.txtColorName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Color Name :";
            // 
            // cmbTeamName
            // 
            this.cmbTeamName.FormattingEnabled = true;
            this.cmbTeamName.Location = new System.Drawing.Point(144, 44);
            this.cmbTeamName.Name = "cmbTeamName";
            this.cmbTeamName.Size = new System.Drawing.Size(158, 33);
            this.cmbTeamName.TabIndex = 7;
            // 
            // btnAddNewTeam
            // 
            this.btnAddNewTeam.Location = new System.Drawing.Point(12, 83);
            this.btnAddNewTeam.Name = "btnAddNewTeam";
            this.btnAddNewTeam.Size = new System.Drawing.Size(286, 55);
            this.btnAddNewTeam.TabIndex = 8;
            this.btnAddNewTeam.Text = "Add New Team";
            this.btnAddNewTeam.UseVisualStyleBackColor = true;
            this.btnAddNewTeam.Click += new System.EventHandler(this.btnAddNewTeam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 557);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We Are The Champions 1.0";
            this.tabs.ResumeLayout(false);
            this.tabMatchSchedule.ResumeLayout(false);
            this.tabMatchSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            this.tabTeams.ResumeLayout(false);
            this.tabTeams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            this.tabPlayers.ResumeLayout(false);
            this.tabPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.tabColors.ResumeLayout(false);
            this.tabColors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabMatchSchedule;
        private System.Windows.Forms.Button btnAddNewMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatches;
        private System.Windows.Forms.TabPage tabTeams;
        private System.Windows.Forms.TabPage tabPlayers;
        private System.Windows.Forms.TabPage tabColors;
        private System.Windows.Forms.Button btnEditMatch;
        private System.Windows.Forms.Button btnDeleteMatch;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.Button btnAddTeamColor;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnAddNewPlayer;
        private System.Windows.Forms.ComboBox cmbTeamList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.ComboBox cmbTeamName;
        private System.Windows.Forms.Button btnAddNewTeam;
    }
}

