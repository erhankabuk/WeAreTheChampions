
namespace WeAreTheChampions
{
    partial class TeamEditMatch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TeamMatchMainTab = new System.Windows.Forms.TabControl();
            this.tabTeamMatch = new System.Windows.Forms.TabPage();
            this.dgvEditMatch = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudScore2 = new System.Windows.Forms.NumericUpDown();
            this.nudScore1 = new System.Windows.Forms.NumericUpDown();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditMatch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTeam1inEditMatch = new System.Windows.Forms.TextBox();
            this.txtTeam2inEditMatch = new System.Windows.Forms.TextBox();
            this.TeamMatchMainTab.SuspendLayout();
            this.tabTeamMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditMatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamMatchMainTab
            // 
            this.TeamMatchMainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamMatchMainTab.Controls.Add(this.tabTeamMatch);
            this.TeamMatchMainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeamMatchMainTab.Location = new System.Drawing.Point(9, 14);
            this.TeamMatchMainTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TeamMatchMainTab.Name = "TeamMatchMainTab";
            this.TeamMatchMainTab.SelectedIndex = 0;
            this.TeamMatchMainTab.Size = new System.Drawing.Size(900, 530);
            this.TeamMatchMainTab.TabIndex = 4;
            this.TeamMatchMainTab.Tag = "";
            // 
            // tabTeamMatch
            // 
            this.tabTeamMatch.BackColor = System.Drawing.Color.LightGray;
            this.tabTeamMatch.Controls.Add(this.txtTeam2inEditMatch);
            this.tabTeamMatch.Controls.Add(this.txtTeam1inEditMatch);
            this.tabTeamMatch.Controls.Add(this.dgvEditMatch);
            this.tabTeamMatch.Controls.Add(this.label4);
            this.tabTeamMatch.Controls.Add(this.label5);
            this.tabTeamMatch.Controls.Add(this.nudScore2);
            this.tabTeamMatch.Controls.Add(this.nudScore1);
            this.tabTeamMatch.Controls.Add(this.dtpTime);
            this.tabTeamMatch.Controls.Add(this.dtpDate);
            this.tabTeamMatch.Controls.Add(this.label2);
            this.tabTeamMatch.Controls.Add(this.label3);
            this.tabTeamMatch.Controls.Add(this.label1);
            this.tabTeamMatch.Controls.Add(this.btnEditMatch);
            this.tabTeamMatch.Controls.Add(this.label8);
            this.tabTeamMatch.Location = new System.Drawing.Point(4, 34);
            this.tabTeamMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeamMatch.Name = "tabTeamMatch";
            this.tabTeamMatch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeamMatch.Size = new System.Drawing.Size(892, 492);
            this.tabTeamMatch.TabIndex = 2;
            this.tabTeamMatch.Text = "Match";
            // 
            // dgvEditMatch
            // 
            this.dgvEditMatch.AllowUserToAddRows = false;
            this.dgvEditMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditMatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column12,
            this.Column13,
            this.Column11});
            this.dgvEditMatch.Location = new System.Drawing.Point(8, 201);
            this.dgvEditMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEditMatch.MultiSelect = false;
            this.dgvEditMatch.Name = "dgvEditMatch";
            this.dgvEditMatch.ReadOnly = true;
            this.dgvEditMatch.RowHeadersVisible = false;
            this.dgvEditMatch.RowHeadersWidth = 51;
            this.dgvEditMatch.RowTemplate.Height = 24;
            this.dgvEditMatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditMatch.Size = new System.Drawing.Size(869, 282);
            this.dgvEditMatch.TabIndex = 24;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Team1TeamName";
            dataGridViewCellStyle5.NullValue = "?";
            this.Column9.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column9.HeaderText = "Team1";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Team2TeamName";
            dataGridViewCellStyle6.NullValue = "?";
            this.Column10.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column10.HeaderText = "Team2";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "MatchDate";
            dataGridViewCellStyle7.Format = "dd:MM:yyyy";
            this.Column12.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column12.HeaderText = "Date";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "MatchTime";
            dataGridViewCellStyle8.Format = "HH:mm";
            this.Column13.DefaultCellStyle = dataGridViewCellStyle8;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Team2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Team1 :";
            // 
            // nudScore2
            // 
            this.nudScore2.Location = new System.Drawing.Point(683, 89);
            this.nudScore2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudScore2.Name = "nudScore2";
            this.nudScore2.Size = new System.Drawing.Size(81, 30);
            this.nudScore2.TabIndex = 17;
            // 
            // nudScore1
            // 
            this.nudScore1.Location = new System.Drawing.Point(683, 30);
            this.nudScore1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudScore1.Name = "nudScore1";
            this.nudScore1.Size = new System.Drawing.Size(81, 30);
            this.nudScore1.TabIndex = 16;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm ";
            this.dtpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(377, 94);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(203, 30);
            this.dtpTime.TabIndex = 15;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(379, 32);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2021, 10, 19, 14, 35, 19, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(207, 30);
            this.dtpDate.TabIndex = 14;
            this.dtpDate.Value = new System.DateTime(2021, 10, 19, 14, 35, 19, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score2 :";
            // 
            // btnEditMatch
            // 
            this.btnEditMatch.Location = new System.Drawing.Point(12, 138);
            this.btnEditMatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditMatch.Name = "btnEditMatch";
            this.btnEditMatch.Size = new System.Drawing.Size(285, 55);
            this.btnEditMatch.TabIndex = 2;
            this.btnEditMatch.Text = "Edit Match";
            this.btnEditMatch.UseVisualStyleBackColor = true;
            this.btnEditMatch.Click += new System.EventHandler(this.btnEditMatch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(587, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Score1 :";
            // 
            // txtTeam1inEditMatch
            // 
            this.txtTeam1inEditMatch.Location = new System.Drawing.Point(98, 29);
            this.txtTeam1inEditMatch.Name = "txtTeam1inEditMatch";
            this.txtTeam1inEditMatch.Size = new System.Drawing.Size(199, 30);
            this.txtTeam1inEditMatch.TabIndex = 25;
            // 
            // txtTeam2inEditMatch
            // 
            this.txtTeam2inEditMatch.Location = new System.Drawing.Point(98, 91);
            this.txtTeam2inEditMatch.Name = "txtTeam2inEditMatch";
            this.txtTeam2inEditMatch.Size = new System.Drawing.Size(199, 30);
            this.txtTeam2inEditMatch.TabIndex = 26;
            // 
            // TeamEditMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 558);
            this.Controls.Add(this.TeamMatchMainTab);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeamEditMatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Match";
            this.TeamMatchMainTab.ResumeLayout(false);
            this.tabTeamMatch.ResumeLayout(false);
            this.tabTeamMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditMatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TeamMatchMainTab;
        private System.Windows.Forms.TabPage tabTeamMatch;
        private System.Windows.Forms.NumericUpDown nudScore2;
        private System.Windows.Forms.NumericUpDown nudScore1;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditMatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvEditMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.TextBox txtTeam2inEditMatch;
        private System.Windows.Forms.TextBox txtTeam1inEditMatch;
    }
}