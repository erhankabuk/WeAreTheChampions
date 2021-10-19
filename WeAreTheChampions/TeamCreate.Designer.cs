
namespace WeAreTheChampions
{
    partial class TeamCreate
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
            this.TeamCreateMainTab = new System.Windows.Forms.TabControl();
            this.tabTeamCreate = new System.Windows.Forms.TabPage();
            this.txtCreateTeam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTeamCreate = new System.Windows.Forms.DataGridView();
            this.btnEditTeamName = new System.Windows.Forms.Button();
            this.btnDeleteTeam = new System.Windows.Forms.Button();
            this.btnCreateNewTeam = new System.Windows.Forms.Button();
            this.TeamCreateMainTab.SuspendLayout();
            this.tabTeamCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamCreateMainTab
            // 
            this.TeamCreateMainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamCreateMainTab.Controls.Add(this.tabTeamCreate);
            this.TeamCreateMainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeamCreateMainTab.Location = new System.Drawing.Point(13, 14);
            this.TeamCreateMainTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TeamCreateMainTab.Name = "TeamCreateMainTab";
            this.TeamCreateMainTab.SelectedIndex = 0;
            this.TeamCreateMainTab.Size = new System.Drawing.Size(901, 529);
            this.TeamCreateMainTab.TabIndex = 2;
            this.TeamCreateMainTab.Tag = "";
            // 
            // tabTeamCreate
            // 
            this.tabTeamCreate.BackColor = System.Drawing.Color.LightGray;
            this.tabTeamCreate.Controls.Add(this.txtCreateTeam);
            this.tabTeamCreate.Controls.Add(this.label1);
            this.tabTeamCreate.Controls.Add(this.dgvTeamCreate);
            this.tabTeamCreate.Controls.Add(this.btnEditTeamName);
            this.tabTeamCreate.Controls.Add(this.btnDeleteTeam);
            this.tabTeamCreate.Controls.Add(this.btnCreateNewTeam);
            this.tabTeamCreate.Location = new System.Drawing.Point(4, 34);
            this.tabTeamCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeamCreate.Name = "tabTeamCreate";
            this.tabTeamCreate.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeamCreate.Size = new System.Drawing.Size(893, 491);
            this.tabTeamCreate.TabIndex = 2;
            this.tabTeamCreate.Text = "Create Team";
            // 
            // txtCreateTeam
            // 
            this.txtCreateTeam.Location = new System.Drawing.Point(87, 27);
            this.txtCreateTeam.Name = "txtCreateTeam";
            this.txtCreateTeam.Size = new System.Drawing.Size(203, 30);
            this.txtCreateTeam.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teams :";
            // 
            // dgvTeamCreate
            // 
            this.dgvTeamCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamCreate.Location = new System.Drawing.Point(12, 215);
            this.dgvTeamCreate.MultiSelect = false;
            this.dgvTeamCreate.Name = "dgvTeamCreate";
            this.dgvTeamCreate.ReadOnly = true;
            this.dgvTeamCreate.RowHeadersVisible = false;
            this.dgvTeamCreate.RowHeadersWidth = 51;
            this.dgvTeamCreate.RowTemplate.Height = 24;
            this.dgvTeamCreate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamCreate.Size = new System.Drawing.Size(870, 270);
            this.dgvTeamCreate.TabIndex = 5;
            // 
            // btnEditTeamName
            // 
            this.btnEditTeamName.Location = new System.Drawing.Point(304, 138);
            this.btnEditTeamName.Name = "btnEditTeamName";
            this.btnEditTeamName.Size = new System.Drawing.Size(286, 55);
            this.btnEditTeamName.TabIndex = 3;
            this.btnEditTeamName.Text = "Edit Team Name";
            this.btnEditTeamName.UseVisualStyleBackColor = true;
            this.btnEditTeamName.Click += new System.EventHandler(this.btnEditTeamName_Click);
            // 
            // btnDeleteTeam
            // 
            this.btnDeleteTeam.Location = new System.Drawing.Point(596, 138);
            this.btnDeleteTeam.Name = "btnDeleteTeam";
            this.btnDeleteTeam.Size = new System.Drawing.Size(286, 55);
            this.btnDeleteTeam.TabIndex = 4;
            this.btnDeleteTeam.Text = "Delete Team";
            this.btnDeleteTeam.UseVisualStyleBackColor = true;
            this.btnDeleteTeam.Click += new System.EventHandler(this.btnDeleteTeam_Click);
            // 
            // btnCreateNewTeam
            // 
            this.btnCreateNewTeam.Location = new System.Drawing.Point(12, 138);
            this.btnCreateNewTeam.Name = "btnCreateNewTeam";
            this.btnCreateNewTeam.Size = new System.Drawing.Size(286, 55);
            this.btnCreateNewTeam.TabIndex = 2;
            this.btnCreateNewTeam.Text = "Create New Team";
            this.btnCreateNewTeam.UseVisualStyleBackColor = true;
            this.btnCreateNewTeam.Click += new System.EventHandler(this.btnCreateNewTeam_Click);
            // 
            // TeamCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 557);
            this.Controls.Add(this.TeamCreateMainTab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TeamCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Team";
            this.TeamCreateMainTab.ResumeLayout(false);
            this.tabTeamCreate.ResumeLayout(false);
            this.tabTeamCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamCreate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TeamCreateMainTab;
        private System.Windows.Forms.TabPage tabTeamCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTeamCreate;
        private System.Windows.Forms.Button btnEditTeamName;
        private System.Windows.Forms.Button btnDeleteTeam;
        private System.Windows.Forms.Button btnCreateNewTeam;
        private System.Windows.Forms.TextBox txtCreateTeam;
    }
}