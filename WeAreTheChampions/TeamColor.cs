using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Model;
using Color = WeAreTheChampions.Model.Color;

namespace WeAreTheChampions
{
    public partial class FrmTeamColor : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public FrmTeamColor(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            dgvTeamColors.AutoGenerateColumns = false;
            LoadAllData();
        }

        /// <summary>
        /// Load All Data
        /// </summary>
        private void LoadAllData()
        {                      
            cmbColorinTeamsColor.DataSource = db.Colors.ToList();
            cmbTeamsinTeamColors.DataSource = db.Teams.ToList();
            dgvTeamColors.DataSource = db.TeamColors.ToList();
        }

        /// <summary>
        /// Add New Color To a Team
        /// </summary>
        private void btnAddNewTeamColor_Click(object sender, EventArgs e)
        {
            Color color = (Color)cmbColorinTeamsColor.SelectedItem;
            Team team = (Team)cmbTeamsinTeamColors.SelectedItem;
            if (db.TeamColors.Any(x => (x.TeamId == team.Id) && (x.ColorId == color.Id)))
            {
                MessageBox.Show($"{color.ColorName} is already added to {team.TeamName}");
                return;
            }
            db.TeamColors.Add(new TeamColor() { ColorId = color.Id, TeamId = team.Id });
            db.SaveChanges();
            dgvTeamColors.DataSource = db.TeamColors.ToList();

        }

        /// <summary>
        /// Edit Team Color 
        /// </summary>       
        private void btnEditTeamColors_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedTeamColor = dgvTeamColors.SelectedRows[0];
            TeamColor editingTeamColor = (TeamColor)selectedTeamColor.DataBoundItem;
            Team editedTeamName = (Team)cmbTeamsinTeamColors.SelectedItem;
            Color editedColor = (Color)cmbColorinTeamsColor.SelectedItem;
            if (btnEditTeamColors.Text == "Edit Team Colors")
            {
                if (dgvTeamColors.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please Select a Team From Table");
                    return;
                }
                btnAddNewTeamColor.Enabled = false;
                btnDeleteTeamColor.Enabled = false;
                btnEditTeamColors.Text = "Save Changes";
            }
            else
            {
                if (editedTeamName == null)
                {
                    MessageBox.Show("Please Select a Team");
                    return;
                }
                if (db.TeamColors.Any(x => x.TeamId == editedTeamName.Id && x.ColorId == editedColor.Id))
                {
                    MessageBox.Show($"{editedTeamName.TeamName} already has {editedColor.ColorName}");
                    return;
                }
                editingTeamColor.TeamId = editedTeamName.Id;
                editingTeamColor.ColorId = editedColor.Id;
                btnAddNewTeamColor.Enabled = true;
                btnDeleteTeamColor.Enabled = true;
                btnEditTeamColors.Text = "Edit Team Colors";
                db.SaveChanges();
                dgvTeamColors.DataSource = db.TeamColors.ToList();
            }
        }

        /// <summary>
        /// Delete a Team Color
        /// </summary>
        private void btnDeleteTeamColor_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedTeamColor= dgvTeamColors.SelectedRows[0];
            TeamColor deletedTeamColor = (TeamColor)selectedTeamColor.DataBoundItem;
            db.TeamColors.Remove(deletedTeamColor);
            db.SaveChanges();
            dgvTeamColors.DataSource = db.TeamColors.ToList();
        }


    }
}
