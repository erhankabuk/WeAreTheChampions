
namespace WeAreTheChampions
{
    partial class FrmTeamColor
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
            this.cmbTeamsinTeamColors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTeamColors = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbColorinTeamsColor = new System.Windows.Forms.ComboBox();
            this.btnEditTeamColors = new System.Windows.Forms.Button();
            this.btnDeleteTeamColor = new System.Windows.Forms.Button();
            this.btnAddNewTeamColor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TeamColorMainTab.SuspendLayout();
            this.tabTeamColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamColors)).BeginInit();
            this.SuspendLayout();
            // 
            // TeamColorMainTab
            // 
            this.TeamColorMainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeamColorMainTab.Controls.Add(this.tabTeamColor);
            this.TeamColorMainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeamColorMainTab.Location = new System.Drawing.Point(9, 14);
            this.TeamColorMainTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TeamColorMainTab.Name = "TeamColorMainTab";
            this.TeamColorMainTab.SelectedIndex = 0;
            this.TeamColorMainTab.Size = new System.Drawing.Size(900, 530);
            this.TeamColorMainTab.TabIndex = 1;
            this.TeamColorMainTab.Tag = "";
            // 
            // tabTeamColor
            // 
            this.tabTeamColor.BackColor = System.Drawing.Color.LightGray;
            this.tabTeamColor.Controls.Add(this.cmbTeamsinTeamColors);
            this.tabTeamColor.Controls.Add(this.label1);
            this.tabTeamColor.Controls.Add(this.dgvTeamColors);
            this.tabTeamColor.Controls.Add(this.cmbColorinTeamsColor);
            this.tabTeamColor.Controls.Add(this.btnEditTeamColors);
            this.tabTeamColor.Controls.Add(this.btnDeleteTeamColor);
            this.tabTeamColor.Controls.Add(this.btnAddNewTeamColor);
            this.tabTeamColor.Controls.Add(this.label8);
            this.tabTeamColor.Location = new System.Drawing.Point(4, 34);
            this.tabTeamColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeamColor.Name = "tabTeamColor";
            this.tabTeamColor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTeamColor.Size = new System.Drawing.Size(892, 492);
            this.tabTeamColor.TabIndex = 2;
            this.tabTeamColor.Text = "Team Colors";
            // 
            // cmbTeamsinTeamColors
            // 
            this.cmbTeamsinTeamColors.DisplayMember = "TeamName";
            this.cmbTeamsinTeamColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamsinTeamColors.FormattingEnabled = true;
            this.cmbTeamsinTeamColors.Location = new System.Drawing.Point(93, 26);
            this.cmbTeamsinTeamColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTeamsinTeamColors.Name = "cmbTeamsinTeamColors";
            this.cmbTeamsinTeamColors.Size = new System.Drawing.Size(203, 33);
            this.cmbTeamsinTeamColors.TabIndex = 6;
            this.cmbTeamsinTeamColors.ValueMember = "Id";
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
            // dgvTeamColors
            // 
            this.dgvTeamColors.AllowUserToAddRows = false;
            this.dgvTeamColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeamColors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeamColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            this.dgvTeamColors.Location = new System.Drawing.Point(12, 215);
            this.dgvTeamColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTeamColors.MultiSelect = false;
            this.dgvTeamColors.Name = "dgvTeamColors";
            this.dgvTeamColors.ReadOnly = true;
            this.dgvTeamColors.RowHeadersVisible = false;
            this.dgvTeamColors.RowHeadersWidth = 51;
            this.dgvTeamColors.RowTemplate.Height = 24;
            this.dgvTeamColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamColors.Size = new System.Drawing.Size(869, 270);
            this.dgvTeamColors.TabIndex = 5;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TeamName";
            this.Column4.HeaderText = "TeamName";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TeamColorList";
            this.Column5.HeaderText = "Color Name";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cmbColorinTeamsColor
            // 
            this.cmbColorinTeamsColor.DisplayMember = "ColorName";
            this.cmbColorinTeamsColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorinTeamsColor.FormattingEnabled = true;
            this.cmbColorinTeamsColor.Location = new System.Drawing.Point(93, 85);
            this.cmbColorinTeamsColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbColorinTeamsColor.Name = "cmbColorinTeamsColor";
            this.cmbColorinTeamsColor.Size = new System.Drawing.Size(203, 33);
            this.cmbColorinTeamsColor.TabIndex = 1;
            this.cmbColorinTeamsColor.ValueMember = "ColorId";
            // 
            // btnEditTeamColors
            // 
            this.btnEditTeamColors.Location = new System.Drawing.Point(304, 138);
            this.btnEditTeamColors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditTeamColors.Name = "btnEditTeamColors";
            this.btnEditTeamColors.Size = new System.Drawing.Size(285, 55);
            this.btnEditTeamColors.TabIndex = 3;
            this.btnEditTeamColors.Text = "Edit Team Colors";
            this.btnEditTeamColors.UseVisualStyleBackColor = true;
            this.btnEditTeamColors.Click += new System.EventHandler(this.btnEditTeamColors_Click);
            // 
            // btnDeleteTeamColor
            // 
            this.btnDeleteTeamColor.Location = new System.Drawing.Point(596, 138);
            this.btnDeleteTeamColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteTeamColor.Name = "btnDeleteTeamColor";
            this.btnDeleteTeamColor.Size = new System.Drawing.Size(285, 55);
            this.btnDeleteTeamColor.TabIndex = 4;
            this.btnDeleteTeamColor.Text = "Delete Team Colors";
            this.btnDeleteTeamColor.UseVisualStyleBackColor = true;
            this.btnDeleteTeamColor.Click += new System.EventHandler(this.btnDeleteTeamColor_Click);
            // 
            // btnAddNewTeamColor
            // 
            this.btnAddNewTeamColor.Location = new System.Drawing.Point(12, 138);
            this.btnAddNewTeamColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewTeamColor.Name = "btnAddNewTeamColor";
            this.btnAddNewTeamColor.Size = new System.Drawing.Size(285, 55);
            this.btnAddNewTeamColor.TabIndex = 2;
            this.btnAddNewTeamColor.Text = "Add New Team Color";
            this.btnAddNewTeamColor.UseVisualStyleBackColor = true;
            this.btnAddNewTeamColor.Click += new System.EventHandler(this.btnAddNewTeamColor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Colors :";
            // 
            // FrmTeamColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 558);
            this.Controls.Add(this.TeamColorMainTab);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTeamColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Team Colors";
            this.TeamColorMainTab.ResumeLayout(false);
            this.tabTeamColor.ResumeLayout(false);
            this.tabTeamColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamColors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TeamColorMainTab;
        private System.Windows.Forms.TabPage tabTeamColor;
        private System.Windows.Forms.Button btnEditTeamColors;
        private System.Windows.Forms.Button btnDeleteTeamColor;
        private System.Windows.Forms.Button btnAddNewTeamColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTeamColors;
        private System.Windows.Forms.ComboBox cmbTeamsinTeamColors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbColorinTeamsColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}