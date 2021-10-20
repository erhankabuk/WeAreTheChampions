
namespace WeAreTheChampions
{
    partial class TeamPlayers
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
            this.TeamColorMainTab = new System.Windows.Forms.TabControl();
            this.tabTeamColor = new System.Windows.Forms.TabPage();
            this.dgvTeamPlayersinTeam = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTeamsinTeamPlayers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlayersinTeamPlayers = new System.Windows.Forms.ComboBox();
            this.btnRemoveTeamPlayer = new System.Windows.Forms.Button();
            this.btnAddNewPlayer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TeamColorMainTab.SuspendLayout();
            this.tabTeamColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamPlayersinTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamColorMainTab
            // 
            this.TeamColorMainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamColorMainTab.Controls.Add(this.tabTeamColor);
            this.TeamColorMainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeamColorMainTab.Location = new System.Drawing.Point(9, 13);
            this.TeamColorMainTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TeamColorMainTab.Name = "TeamColorMainTab";
            this.TeamColorMainTab.SelectedIndex = 0;
            this.TeamColorMainTab.Size = new System.Drawing.Size(900, 531);
            this.TeamColorMainTab.TabIndex = 2;
            this.TeamColorMainTab.Tag = "";
            // 
            // tabTeamColor
            // 
            this.tabTeamColor.BackColor = System.Drawing.Color.LightGray;
            this.tabTeamColor.Controls.Add(this.dgvTeamPlayersinTeam);
            this.tabTeamColor.Controls.Add(this.cmbTeamsinTeamPlayers);
            this.tabTeamColor.Controls.Add(this.label1);
            this.tabTeamColor.Controls.Add(this.cmbPlayersinTeamPlayers);
            this.tabTeamColor.Controls.Add(this.btnRemoveTeamPlayer);
            this.tabTeamColor.Controls.Add(this.btnAddNewPlayer);
            this.tabTeamColor.Controls.Add(this.label8);
            this.tabTeamColor.Location = new System.Drawing.Point(4, 34);
            this.tabTeamColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeamColor.Name = "tabTeamColor";
            this.tabTeamColor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeamColor.Size = new System.Drawing.Size(892, 493);
            this.tabTeamColor.TabIndex = 2;
            this.tabTeamColor.Text = "Team Players";
            // 
            // dgvTeamPlayersinTeam
            // 
            this.dgvTeamPlayersinTeam.AllowUserToAddRows = false;
            this.dgvTeamPlayersinTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamPlayersinTeam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvTeamPlayersinTeam.Location = new System.Drawing.Point(12, 213);
            this.dgvTeamPlayersinTeam.MultiSelect = false;
            this.dgvTeamPlayersinTeam.Name = "dgvTeamPlayersinTeam";
            this.dgvTeamPlayersinTeam.ReadOnly = true;
            this.dgvTeamPlayersinTeam.RowHeadersVisible = false;
            this.dgvTeamPlayersinTeam.RowHeadersWidth = 51;
            this.dgvTeamPlayersinTeam.RowTemplate.Height = 24;
            this.dgvTeamPlayersinTeam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamPlayersinTeam.Size = new System.Drawing.Size(873, 272);
            this.dgvTeamPlayersinTeam.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PlayerName";
            this.Column1.HeaderText = "Player Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PlayerTeamName";
            this.Column2.HeaderText = "Team";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // cmbTeamsinTeamPlayers
            // 
            this.cmbTeamsinTeamPlayers.DisplayMember = "TeamName";
            this.cmbTeamsinTeamPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamsinTeamPlayers.FormattingEnabled = true;
            this.cmbTeamsinTeamPlayers.Location = new System.Drawing.Point(95, 85);
            this.cmbTeamsinTeamPlayers.Name = "cmbTeamsinTeamPlayers";
            this.cmbTeamsinTeamPlayers.Size = new System.Drawing.Size(203, 33);
            this.cmbTeamsinTeamPlayers.TabIndex = 6;
            this.cmbTeamsinTeamPlayers.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teams :";
            // 
            // cmbPlayersinTeamPlayers
            // 
            this.cmbPlayersinTeamPlayers.DisplayMember = "PlayerName";
            this.cmbPlayersinTeamPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayersinTeamPlayers.FormattingEnabled = true;
            this.cmbPlayersinTeamPlayers.Location = new System.Drawing.Point(95, 26);
            this.cmbPlayersinTeamPlayers.Name = "cmbPlayersinTeamPlayers";
            this.cmbPlayersinTeamPlayers.Size = new System.Drawing.Size(203, 33);
            this.cmbPlayersinTeamPlayers.TabIndex = 1;
            this.cmbPlayersinTeamPlayers.ValueMember = "Id";
            // 
            // btnRemoveTeamPlayer
            // 
            this.btnRemoveTeamPlayer.Location = new System.Drawing.Point(304, 138);
            this.btnRemoveTeamPlayer.Name = "btnRemoveTeamPlayer";
            this.btnRemoveTeamPlayer.Size = new System.Drawing.Size(286, 55);
            this.btnRemoveTeamPlayer.TabIndex = 3;
            this.btnRemoveTeamPlayer.Text = "Remove Player";
            this.btnRemoveTeamPlayer.UseVisualStyleBackColor = true;
            this.btnRemoveTeamPlayer.Click += new System.EventHandler(this.btnRemoveTeamPlayer_Click);
            // 
            // btnAddNewPlayer
            // 
            this.btnAddNewPlayer.Location = new System.Drawing.Point(12, 138);
            this.btnAddNewPlayer.Name = "btnAddNewPlayer";
            this.btnAddNewPlayer.Size = new System.Drawing.Size(286, 55);
            this.btnAddNewPlayer.TabIndex = 2;
            this.btnAddNewPlayer.Text = "Add-Edit New Player";
            this.btnAddNewPlayer.UseVisualStyleBackColor = true;
            this.btnAddNewPlayer.Click += new System.EventHandler(this.btnAddNewPlayer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Players :";
            // 
            // TeamPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 557);
            this.Controls.Add(this.TeamColorMainTab);
            this.Name = "TeamPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Players";
            this.TeamColorMainTab.ResumeLayout(false);
            this.tabTeamColor.ResumeLayout(false);
            this.tabTeamColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamPlayersinTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TeamColorMainTab;
        private System.Windows.Forms.TabPage tabTeamColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPlayersinTeamPlayers;
        private System.Windows.Forms.Button btnRemoveTeamPlayer;
        private System.Windows.Forms.Button btnAddNewPlayer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTeamPlayersinTeam;
        private System.Windows.Forms.ComboBox cmbTeamsinTeamPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}