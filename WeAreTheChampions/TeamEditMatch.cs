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
    public partial class TeamEditMatch : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public TeamEditMatch(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            dgvEditMatch.AutoGenerateColumns = false;
            LoadAllData();
        }
        /// <summary>
        /// Load All Data
        /// </summary>
        private void LoadAllData()
        {
            dgvEditMatch.DataSource = db.Matches.OrderByDescending(x => x.MatchTime.Hour).ToList();
        }

        /// <summary>
        /// Edit a Match
        /// </summary>      
        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedMatch = dgvEditMatch.SelectedRows[0];
            Match match = (Match)selectedMatch.DataBoundItem;
            txtTeam1inEditMatch.Text = match.Team1TeamName;
            txtTeam2inEditMatch.Text = match.Team2TeamName;
            txtTeam1inEditMatch.Enabled = false;
            txtTeam2inEditMatch.Enabled = false;
            if (btnEditMatch.Text == "Edit Match")
            {
                if (dgvEditMatch.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please Select a Match");
                    return;
                }
                dtpDate.Value = match.MatchDate;
                dtpTime.Value = dtpDate.Value;
                btnEditMatch.Text = "Save Changes";
            }
            else
            {
                if (db.Matches.Any(x => x.Team1.TeamName == txtTeam1inEditMatch.Text && x.Team2.TeamName == txtTeam2inEditMatch.Text && x.MatchDate.Day == dtpDate.Value.Day && x.MatchTime.Hour == dtpTime.Value.Hour && x.MatchTime.Minute == dtpTime.Value.Minute))
                {
                    MessageBox.Show("This Match already existed.");
                    return;
                }

                match.MatchDate = dtpDate.Value;
                match.MatchTime = dtpTime.Value;
                match.Score1 = (int?)nudScore1.Value;
                match.Score2 = (int?)nudScore2.Value;
                btnEditMatch.Text = "Edit Match";
                db.SaveChanges();
                dgvEditMatch.DataSource = db.Matches.ToList();
            }
        }
    }
}
