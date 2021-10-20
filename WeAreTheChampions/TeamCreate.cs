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

namespace WeAreTheChampions
{
    public partial class TeamCreate : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public TeamCreate(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            dgvTeamCreate.AutoGenerateColumns = false;
            LoadAllData();
        }
        /// <summary>
        /// Load All Data
        /// </summary>
        private void LoadAllData()
        {
            dgvTeamCreate.DataSource = db.Teams.ToList();
        }
        /// <summary>
        /// Create a New Team with Team Name
        /// </summary>
        private void btnCreateNewTeam_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedTeam = dgvTeamCreate.SelectedRows[0];
            Team team = (Team)selectedTeam.DataBoundItem;
            string teamName = txtCreateTeam.Text.Trim();
            if (teamName == string.Empty)
            {
                MessageBox.Show("Please Enter a Team Name");
                return;
            }
            if (db.Teams.Any(x => x.TeamName == teamName))
            {
                MessageBox.Show($"{teamName} is already existed.Try Another Team Name");
                return;
            }
            db.Teams.Add(new Team() { TeamName = teamName });
            db.SaveChanges();
            dgvTeamCreate.DataSource = db.Teams.ToList();
        }
        /// <summary>
        /// Edit Team Name
        /// </summary>      
        private void btnEditTeamName_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedTeam = dgvTeamCreate.SelectedRows[0];
            Team team = (Team)selectedTeam.DataBoundItem;
            string editingTeamName = team.TeamName;

            if (btnEditTeamName.Text == "Edit Team Name")
            {
                if (dgvTeamCreate.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please Select a Team From Table");
                    return;
                }
                txtCreateTeam.Text = editingTeamName;
                btnEditTeamName.Text = "Save Changes";
                btnCreateNewTeam.Enabled = false;
                btnDeleteTeam.Enabled = false;
            }
            else
            {
                if (txtCreateTeam.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter a Team Name");
                    return;
                }
                if (db.Teams.Any(x => x.TeamName == txtCreateTeam.Text))
                {
                    MessageBox.Show($"{txtCreateTeam.Text} is already existed. Try Another Team Name");
                    return;
                }
                team.TeamName = txtCreateTeam.Text.Trim();
                db.SaveChanges();
                dgvTeamCreate.DataSource = db.Teams.ToList();
                btnEditTeamName.Text = "Edit Team Name";
                btnCreateNewTeam.Enabled = true;
                btnDeleteTeam.Enabled = true;

            }

        }
        /// <summary>
        /// Delete a Team
        /// </summary>
        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvTeamCreate.SelectedRows[0];
            Team team = (Team)selected.DataBoundItem;
            db.Teams.Remove(team);

            foreach (var item in db.Matches)
            {
                if (team.Id==null)
                {
                    db.Matches.Remove(item);
                }
            }            
            db.SaveChanges();
            dgvTeamCreate.DataSource = db.Teams.ToList();
        }
    }
}
