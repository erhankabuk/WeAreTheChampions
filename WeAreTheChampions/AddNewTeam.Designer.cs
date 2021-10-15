
namespace WeAreTheChampions
{
    partial class AddNewTeam
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddNewTeam = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtAddNewTeam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateNewTeam = new System.Windows.Forms.Button();
            this.dgvAddANetTeam = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabAddNewTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddANetTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddNewTeam);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAddNewTeam
            // 
            this.tabAddNewTeam.BackColor = System.Drawing.Color.LightGray;
            this.tabAddNewTeam.Controls.Add(this.dgvAddANetTeam);
            this.tabAddNewTeam.Controls.Add(this.btnCreateNewTeam);
            this.tabAddNewTeam.Controls.Add(this.txtAddNewTeam);
            this.tabAddNewTeam.Controls.Add(this.label2);
            this.tabAddNewTeam.Location = new System.Drawing.Point(4, 34);
            this.tabAddNewTeam.Name = "tabAddNewTeam";
            this.tabAddNewTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddNewTeam.Size = new System.Drawing.Size(601, 388);
            this.tabAddNewTeam.TabIndex = 0;
            this.tabAddNewTeam.Text = "Add New Team";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 62);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAddNewTeam
            // 
            this.txtAddNewTeam.Location = new System.Drawing.Point(187, 14);
            this.txtAddNewTeam.Name = "txtAddNewTeam";
            this.txtAddNewTeam.Size = new System.Drawing.Size(142, 30);
            this.txtAddNewTeam.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Team Name :";
            // 
            // btnCreateNewTeam
            // 
            this.btnCreateNewTeam.Location = new System.Drawing.Point(11, 50);
            this.btnCreateNewTeam.Name = "btnCreateNewTeam";
            this.btnCreateNewTeam.Size = new System.Drawing.Size(318, 55);
            this.btnCreateNewTeam.TabIndex = 9;
            this.btnCreateNewTeam.Text = "Create New Team";
            this.btnCreateNewTeam.UseVisualStyleBackColor = true;
            this.btnCreateNewTeam.Click += new System.EventHandler(this.btnCreateNewTeam_Click);
            // 
            // dgvAddANetTeam
            // 
            this.dgvAddANetTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddANetTeam.Location = new System.Drawing.Point(11, 111);
            this.dgvAddANetTeam.Name = "dgvAddANetTeam";
            this.dgvAddANetTeam.RowHeadersVisible = false;
            this.dgvAddANetTeam.RowHeadersWidth = 51;
            this.dgvAddANetTeam.RowTemplate.Height = 24;
            this.dgvAddANetTeam.Size = new System.Drawing.Size(575, 271);
            this.dgvAddANetTeam.TabIndex = 10;
            // 
            // AddNewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddNewTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add  A New Team";
            this.tabControl1.ResumeLayout(false);
            this.tabAddNewTeam.ResumeLayout(false);
            this.tabAddNewTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddANetTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddNewTeam;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAddNewTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateNewTeam;
        private System.Windows.Forms.DataGridView dgvAddANetTeam;
    }
}