
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabMatchSchedule = new System.Windows.Forms.TabPage();
            this.btnEditMatch = new System.Windows.Forms.Button();
            this.btnDeleteMatch = new System.Windows.Forms.Button();
            this.btnAddNewMatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabTeams = new System.Windows.Forms.TabPage();
            this.btnAddNewTeam = new System.Windows.Forms.Button();
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTeamColor = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.chkTeamMember = new System.Windows.Forms.CheckBox();
            this.cmbTeamList = new System.Windows.Forms.ComboBox();
            this.btnEditPlayer = new System.Windows.Forms.Button();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNewPlayer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabColors = new System.Windows.Forms.TabPage();
            this.btnEditColor = new System.Windows.Forms.Button();
            this.btnDeleteColor = new System.Windows.Forms.Button();
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabMatchSchedule.Size = new System.Drawing.Size(892, 493);
            this.tabMatchSchedule.TabIndex = 0;
            this.tabMatchSchedule.Text = "Match Schedule";
            // 
            // btnEditMatch
            // 
            this.btnEditMatch.Location = new System.Drawing.Point(300, 431);
            this.btnEditMatch.Name = "btnEditMatch";
            this.btnEditMatch.Size = new System.Drawing.Size(286, 55);
            this.btnEditMatch.TabIndex = 2;
            this.btnEditMatch.Text = "Edit Match";
            this.btnEditMatch.UseVisualStyleBackColor = true;
            this.btnEditMatch.Click += new System.EventHandler(this.btnEditMatch_Click);
            // 
            // btnDeleteMatch
            // 
            this.btnDeleteMatch.Location = new System.Drawing.Point(592, 431);
            this.btnDeleteMatch.Name = "btnDeleteMatch";
            this.btnDeleteMatch.Size = new System.Drawing.Size(286, 55);
            this.btnDeleteMatch.TabIndex = 3;
            this.btnDeleteMatch.Text = "Delete Match";
            this.btnDeleteMatch.UseVisualStyleBackColor = true;
            this.btnDeleteMatch.Click += new System.EventHandler(this.btnDeleteMatch_Click);
            // 
            // btnAddNewMatch
            // 
            this.btnAddNewMatch.Location = new System.Drawing.Point(8, 431);
            this.btnAddNewMatch.Name = "btnAddNewMatch";
            this.btnAddNewMatch.Size = new System.Drawing.Size(286, 55);
            this.btnAddNewMatch.TabIndex = 1;
            this.btnAddNewMatch.Text = "Add New Match";
            this.btnAddNewMatch.UseVisualStyleBackColor = true;
            this.btnAddNewMatch.Click += new System.EventHandler(this.btnAddNewMatch_Click);
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
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column12,
            this.Column13,
            this.Column11});
            this.dgvMatches.Location = new System.Drawing.Point(8, 71);
            this.dgvMatches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMatches.MultiSelect = false;
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.RowHeadersWidth = 51;
            this.dgvMatches.RowTemplate.Height = 24;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(870, 352);
            this.dgvMatches.TabIndex = 0;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Team1TeamName";
            dataGridViewCellStyle21.NullValue = "?";
            this.Column9.DefaultCellStyle = dataGridViewCellStyle21;
            this.Column9.HeaderText = "Team1";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Team2TeamName";
            dataGridViewCellStyle22.NullValue = "?";
            this.Column10.DefaultCellStyle = dataGridViewCellStyle22;
            this.Column10.HeaderText = "Team2";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "MatchDate";
            dataGridViewCellStyle23.Format = "dd:MM:yyyy";
            this.Column12.DefaultCellStyle = dataGridViewCellStyle23;
            this.Column12.HeaderText = "Date";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "MatchTime";
            dataGridViewCellStyle24.Format = "HH:mm";
            this.Column13.DefaultCellStyle = dataGridViewCellStyle24;
            this.Column13.HeaderText = "Time";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MatchScore";
            this.Column11.HeaderText = "Score";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 125;
            // 
            // tabTeams
            // 
            this.tabTeams.BackColor = System.Drawing.Color.LightGray;
            this.tabTeams.Controls.Add(this.btnAddNewTeam);
            this.tabTeams.Controls.Add(this.dgvTeams);
            this.tabTeams.Controls.Add(this.btnAddTeamColor);
            this.tabTeams.Controls.Add(this.btnAddPlayer);
            this.tabTeams.Location = new System.Drawing.Point(4, 34);
            this.tabTeams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeams.Name = "tabTeams";
            this.tabTeams.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeams.Size = new System.Drawing.Size(892, 493);
            this.tabTeams.TabIndex = 1;
            this.tabTeams.Text = "Teams";
            // 
            // btnAddNewTeam
            // 
            this.btnAddNewTeam.Location = new System.Drawing.Point(12, 83);
            this.btnAddNewTeam.Name = "btnAddNewTeam";
            this.btnAddNewTeam.Size = new System.Drawing.Size(286, 55);
            this.btnAddNewTeam.TabIndex = 1;
            this.btnAddNewTeam.Text = "Create-Remove Team";
            this.btnAddNewTeam.UseVisualStyleBackColor = true;
            this.btnAddNewTeam.Click += new System.EventHandler(this.btnAddNewTeam_Click);
            // 
            // dgvTeams
            // 
            this.dgvTeams.AllowUserToAddRows = false;
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8});
            this.dgvTeams.Location = new System.Drawing.Point(12, 146);
            this.dgvTeams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTeams.MultiSelect = false;
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.ReadOnly = true;
            this.dgvTeams.RowHeadersVisible = false;
            this.dgvTeams.RowHeadersWidth = 51;
            this.dgvTeams.RowTemplate.Height = 24;
            this.dgvTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeams.Size = new System.Drawing.Size(870, 342);
            this.dgvTeams.TabIndex = 4;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Id";
            this.Column4.HeaderText = "Id";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TeamName";
            this.Column5.HeaderText = "Team Name";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PlayerList";
            this.Column6.HeaderText = "Team Players";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ColorList";
            this.Column8.HeaderText = "Team Colors";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // btnAddTeamColor
            // 
            this.btnAddTeamColor.Location = new System.Drawing.Point(596, 83);
            this.btnAddTeamColor.Name = "btnAddTeamColor";
            this.btnAddTeamColor.Size = new System.Drawing.Size(286, 55);
            this.btnAddTeamColor.TabIndex = 3;
            this.btnAddTeamColor.Text = "Add-Remove Team Color";
            this.btnAddTeamColor.UseVisualStyleBackColor = true;
            this.btnAddTeamColor.Click += new System.EventHandler(this.btnAddTeamColor_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(304, 83);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(286, 55);
            this.btnAddPlayer.TabIndex = 2;
            this.btnAddPlayer.Text = "Add-Remove Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // tabPlayers
            // 
            this.tabPlayers.BackColor = System.Drawing.Color.LightGray;
            this.tabPlayers.Controls.Add(this.chkTeamMember);
            this.tabPlayers.Controls.Add(this.cmbTeamList);
            this.tabPlayers.Controls.Add(this.btnEditPlayer);
            this.tabPlayers.Controls.Add(this.btnDeletePlayer);
            this.tabPlayers.Controls.Add(this.dgvPlayers);
            this.tabPlayers.Controls.Add(this.btnAddNewPlayer);
            this.tabPlayers.Controls.Add(this.label8);
            this.tabPlayers.Controls.Add(this.txtPlayerName);
            this.tabPlayers.Controls.Add(this.label7);
            this.tabPlayers.Location = new System.Drawing.Point(4, 34);
            this.tabPlayers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPlayers.Size = new System.Drawing.Size(892, 493);
            this.tabPlayers.TabIndex = 2;
            this.tabPlayers.Text = "Players";
            // 
            // chkTeamMember
            // 
            this.chkTeamMember.AutoSize = true;
            this.chkTeamMember.Checked = true;
            this.chkTeamMember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTeamMember.Location = new System.Drawing.Point(304, 88);
            this.chkTeamMember.Name = "chkTeamMember";
            this.chkTeamMember.Size = new System.Drawing.Size(282, 29);
            this.chkTeamMember.TabIndex = 6;
            this.chkTeamMember.Text = "Set Player as a Team Player";
            this.chkTeamMember.UseVisualStyleBackColor = true;
            this.chkTeamMember.Click += new System.EventHandler(this.chkTeamMember_Click);
            // 
            // cmbTeamList
            // 
            this.cmbTeamList.DisplayMember = "TeamName";
            this.cmbTeamList.FormattingEnabled = true;
            this.cmbTeamList.Location = new System.Drawing.Point(87, 86);
            this.cmbTeamList.Name = "cmbTeamList";
            this.cmbTeamList.Size = new System.Drawing.Size(211, 33);
            this.cmbTeamList.TabIndex = 1;
            this.cmbTeamList.ValueMember = "TeamId";
            // 
            // btnEditPlayer
            // 
            this.btnEditPlayer.Location = new System.Drawing.Point(304, 138);
            this.btnEditPlayer.Name = "btnEditPlayer";
            this.btnEditPlayer.Size = new System.Drawing.Size(286, 55);
            this.btnEditPlayer.TabIndex = 3;
            this.btnEditPlayer.Text = "Edit Player";
            this.btnEditPlayer.UseVisualStyleBackColor = true;
            this.btnEditPlayer.Click += new System.EventHandler(this.btnEditPlayer_Click);
            // 
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.Location = new System.Drawing.Point(596, 138);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(286, 55);
            this.btnDeletePlayer.TabIndex = 4;
            this.btnDeletePlayer.Text = "Delete Player";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            this.btnDeletePlayer.Click += new System.EventHandler(this.btnDeletePlayer_Click);
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPlayers.Location = new System.Drawing.Point(12, 221);
            this.dgvPlayers.MultiSelect = false;
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.RowHeadersWidth = 51;
            this.dgvPlayers.RowTemplate.Height = 24;
            this.dgvPlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayers.Size = new System.Drawing.Size(873, 264);
            this.dgvPlayers.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PlayerName";
            this.Column2.HeaderText = "Player Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PlayerTeamName";
            dataGridViewCellStyle25.NullValue = "-";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle25;
            this.Column3.HeaderText = "Team Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // btnAddNewPlayer
            // 
            this.btnAddNewPlayer.Location = new System.Drawing.Point(12, 138);
            this.btnAddNewPlayer.Name = "btnAddNewPlayer";
            this.btnAddNewPlayer.Size = new System.Drawing.Size(286, 55);
            this.btnAddNewPlayer.TabIndex = 2;
            this.btnAddNewPlayer.Text = "Add New Player";
            this.btnAddNewPlayer.UseVisualStyleBackColor = true;
            this.btnAddNewPlayer.Click += new System.EventHandler(this.btnAddNewPlayer_Click);
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
            this.txtPlayerName.Location = new System.Drawing.Point(148, 31);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(150, 30);
            this.txtPlayerName.TabIndex = 0;
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
            // tabColors
            // 
            this.tabColors.BackColor = System.Drawing.Color.LightGray;
            this.tabColors.Controls.Add(this.btnEditColor);
            this.tabColors.Controls.Add(this.btnDeleteColor);
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
            // btnEditColor
            // 
            this.btnEditColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditColor.Location = new System.Drawing.Point(299, 166);
            this.btnEditColor.Name = "btnEditColor";
            this.btnEditColor.Size = new System.Drawing.Size(286, 55);
            this.btnEditColor.TabIndex = 5;
            this.btnEditColor.Text = "Edit Color";
            this.btnEditColor.UseVisualStyleBackColor = true;
            this.btnEditColor.Click += new System.EventHandler(this.btnEditColor_Click);
            // 
            // btnDeleteColor
            // 
            this.btnDeleteColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteColor.Location = new System.Drawing.Point(591, 166);
            this.btnDeleteColor.Name = "btnDeleteColor";
            this.btnDeleteColor.Size = new System.Drawing.Size(286, 55);
            this.btnDeleteColor.TabIndex = 6;
            this.btnDeleteColor.Text = "Delete Color";
            this.btnDeleteColor.UseVisualStyleBackColor = true;
            this.btnDeleteColor.Click += new System.EventHandler(this.btnDeleteColor_Click);
            // 
            // dgvColors
            // 
            this.dgvColors.AllowUserToAddRows = false;
            this.dgvColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17});
            this.dgvColors.Location = new System.Drawing.Point(8, 252);
            this.dgvColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvColors.MultiSelect = false;
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.ReadOnly = true;
            this.dgvColors.RowHeadersVisible = false;
            this.dgvColors.RowHeadersWidth = 51;
            this.dgvColors.RowTemplate.Height = 24;
            this.dgvColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColors.Size = new System.Drawing.Size(869, 231);
            this.dgvColors.TabIndex = 9;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Id";
            this.Column7.HeaderText = "Id";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "ColorName";
            this.Column14.HeaderText = "Color Name";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 125;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "Red";
            this.Column15.HeaderText = "Red";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 125;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "Green";
            this.Column16.HeaderText = "Green";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 125;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "Blue";
            this.Column17.HeaderText = "Blue";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 125;
            // 
            // btnAddColor
            // 
            this.btnAddColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddColor.Location = new System.Drawing.Point(7, 166);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(286, 55);
            this.btnAddColor.TabIndex = 4;
            this.btnAddColor.Text = "Add New Color";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // nudGreen
            // 
            this.nudGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudGreen.Location = new System.Drawing.Point(252, 106);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(72, 30);
            this.nudGreen.TabIndex = 2;
            // 
            // nudBlue
            // 
            this.nudBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudBlue.Location = new System.Drawing.Point(413, 106);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(72, 30);
            this.nudBlue.TabIndex = 3;
            // 
            // nudRed
            // 
            this.nudRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRed.Location = new System.Drawing.Point(91, 106);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(72, 30);
            this.nudRed.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Red     :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Green :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue    :";
            // 
            // txtColorName
            // 
            this.txtColorName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColorName.Location = new System.Drawing.Point(135, 33);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(158, 30);
            this.txtColorName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Color Name :";
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
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.Button btnAddTeamColor;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnAddNewPlayer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.Button btnAddNewTeam;
        private System.Windows.Forms.Button btnEditColor;
        private System.Windows.Forms.Button btnDeleteColor;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Button btnEditPlayer;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.ComboBox cmbTeamList;
        private System.Windows.Forms.CheckBox chkTeamMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
    }
}

