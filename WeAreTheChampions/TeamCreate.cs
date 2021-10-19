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
            LoadAllData();
        }

        private void LoadAllData()
        {
            dgvTeamCreate.DataSource = db.Teams.ToList();
        }

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

        private void btnDeleteTeam_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvTeamCreate.SelectedRows[0];
            Team team = (Team)selected.DataBoundItem;
            db.Teams.Remove(team);
            db.SaveChanges();
            dgvTeamCreate.DataSource = db.Teams.ToList();
        }

        private void btnEditTeamName_Click(object sender, EventArgs e)
        {
            if (btnEditTeamName.Text == "Edit Team Name")
            {
                if (dgvTeamCreate.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please Select a Team From Table");
                    return;
                }
                btnEditTeamName.Text = "Save Changes";
            }
            else
            {//Start over
                DataGridViewRow selected = dgvTeamCreate.SelectedRows[0];
                Team team = (Team)selected.DataBoundItem;
                txtCreateTeam.Text = team.TeamName;
                string teamName = txtCreateTeam.Text.Trim();
                if (teamName == string.Empty)
                {
                    MessageBox.Show("Please Enter a Team Name");
                    return;
                }
                if (db.Teams.Any(x => x.TeamName == teamName&&x.Id!=team.Id))
                {
                    MessageBox.Show($"{teamName} is already existed. Try Another Team Name");
                    return;
                }
                team.TeamName = txtCreateTeam.Text.Trim();
                db.SaveChanges();
                btnEditTeamName.Text = "Edit Team Name";
                dgvTeamCreate.DataSource = db.Teams.ToList();
            }

        }
    }
}
