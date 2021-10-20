
namespace WeAreTheChampions
{
    partial class TeamMatches
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
            this.TeamMatchMainTab = new System.Windows.Forms.TabControl();
            this.tabTeamMatch = new System.Windows.Forms.TabPage();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCreateMatch = new System.Windows.Forms.DataGridView();
            this.cmbTeam2inMatch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTeam1inMatch = new System.Windows.Forms.ComboBox();
            this.btnAddNewMatch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamMatchMainTab.SuspendLayout();
            this.tabTeamMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamMatchMainTab
            // 
            this.TeamMatchMainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamMatchMainTab.Controls.Add(this.tabTeamMatch);
            this.TeamMatchMainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeamMatchMainTab.Location = new System.Drawing.Point(9, 13);
            this.TeamMatchMainTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TeamMatchMainTab.Name = "TeamMatchMainTab";
            this.TeamMatchMainTab.SelectedIndex = 0;
            this.TeamMatchMainTab.Size = new System.Drawing.Size(900, 531);
            this.TeamMatchMainTab.TabIndex = 3;
            this.TeamMatchMainTab.Tag = "";
            // 
            // tabTeamMatch
            // 
            this.tabTeamMatch.BackColor = System.Drawing.Color.LightGray;
            this.tabTeamMatch.Controls.Add(this.dtpTime);
            this.tabTeamMatch.Controls.Add(this.dtpDate);
            this.tabTeamMatch.Controls.Add(this.label2);
            this.tabTeamMatch.Controls.Add(this.label3);
            this.tabTeamMatch.Controls.Add(this.dgvCreateMatch);
            this.tabTeamMatch.Controls.Add(this.cmbTeam2inMatch);
            this.tabTeamMatch.Controls.Add(this.label1);
            this.tabTeamMatch.Controls.Add(this.cmbTeam1inMatch);
            this.tabTeamMatch.Controls.Add(this.btnAddNewMatch);
            this.tabTeamMatch.Controls.Add(this.label8);
            this.tabTeamMatch.Location = new System.Drawing.Point(4, 34);
            this.tabTeamMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeamMatch.Name = "tabTeamMatch";
            this.tabTeamMatch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeamMatch.Size = new System.Drawing.Size(892, 493);
            this.tabTeamMatch.TabIndex = 2;
            this.tabTeamMatch.Text = "Match";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm ";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(377, 85);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(203, 30);
            this.dtpTime.TabIndex = 15;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(374, 26);
            this.dtpDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2021, 10, 19, 14, 35, 19, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(206, 30);
            this.dtpDate.TabIndex = 14;
            this.dtpDate.Value = new System.DateTime(2021, 10, 19, 14, 35, 19, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date :";
            // 
            // dgvCreateMatch
            // 
            this.dgvCreateMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreateMatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvCreateMatch.Location = new System.Drawing.Point(12, 221);
            this.dgvCreateMatch.MultiSelect = false;
            this.dgvCreateMatch.Name = "dgvCreateMatch";
            this.dgvCreateMatch.ReadOnly = true;
            this.dgvCreateMatch.RowHeadersVisible = false;
            this.dgvCreateMatch.RowHeadersWidth = 51;
            this.dgvCreateMatch.RowTemplate.Height = 24;
            this.dgvCreateMatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreateMatch.Size = new System.Drawing.Size(873, 264);
            this.dgvCreateMatch.TabIndex = 8;
            // 
            // cmbTeam2inMatch
            // 
            this.cmbTeam2inMatch.DisplayMember = "TeamName";
            this.cmbTeam2inMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam2inMatch.FormattingEnabled = true;
            this.cmbTeam2inMatch.Location = new System.Drawing.Point(95, 85);
            this.cmbTeam2inMatch.Name = "cmbTeam2inMatch";
            this.cmbTeam2inMatch.Size = new System.Drawing.Size(203, 33);
            this.cmbTeam2inMatch.TabIndex = 6;
            this.cmbTeam2inMatch.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Team2 :";
            // 
            // cmbTeam1inMatch
            // 
            this.cmbTeam1inMatch.DisplayMember = "TeamName";
            this.cmbTeam1inMatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeam1inMatch.FormattingEnabled = true;
            this.cmbTeam1inMatch.Location = new System.Drawing.Point(95, 26);
            this.cmbTeam1inMatch.Name = "cmbTeam1inMatch";
            this.cmbTeam1inMatch.Size = new System.Drawing.Size(203, 33);
            this.cmbTeam1inMatch.TabIndex = 1;
            this.cmbTeam1inMatch.ValueMember = "Id";
            // 
            // btnAddNewMatch
            // 
            this.btnAddNewMatch.Location = new System.Drawing.Point(12, 138);
            this.btnAddNewMatch.Name = "btnAddNewMatch";
            this.btnAddNewMatch.Size = new System.Drawing.Size(286, 55);
            this.btnAddNewMatch.TabIndex = 2;
            this.btnAddNewMatch.Text = "Create New Match";
            this.btnAddNewMatch.UseVisualStyleBackColor = true;
            this.btnAddNewMatch.Click += new System.EventHandler(this.btnAddNewMatch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Team1 :";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Team1TeamName";
            this.Column1.HeaderText = "Team1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Team2TeamName";
            this.Column2.HeaderText = "Team2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MatchDate";
            this.Column3.HeaderText = "Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MatchTime";
            this.Column4.HeaderText = "Time";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MatchScore";
            this.Column5.HeaderText = "Score";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // TeamMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 557);
            this.Controls.Add(this.TeamMatchMainTab);
            this.Name = "TeamMatches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Match";
            this.TeamMatchMainTab.ResumeLayout(false);
            this.tabTeamMatch.ResumeLayout(false);
            this.tabTeamMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateMatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TeamMatchMainTab;
        private System.Windows.Forms.TabPage tabTeamMatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCreateMatch;
        private System.Windows.Forms.ComboBox cmbTeam2inMatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTeam1inMatch;
        private System.Windows.Forms.Button btnAddNewMatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}