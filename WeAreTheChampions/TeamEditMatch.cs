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
            dgvEditMatch.DataSource = db.Matches.OrderByDescending(x => x.MatchDate).ToList();
            cmbTeam1inEditMatch.DataSource = db.Teams.ToList();
            cmbTeam2inEditMatch.DataSource = db.Teams.ToList();
        }

        /// <summary>
        /// Edit a Match
        /// </summary>      
        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            if (btnEditMatch.Text == "Edit Match")
            {
                if (dgvEditMatch.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please Select a Match");
                    return;
                }
                DataGridViewRow selectedMatch = dgvEditMatch.SelectedRows[0];
                Match match = (Match)selectedMatch.DataBoundItem;
                cmbTeam1inEditMatch.SelectedItem = match.Team1TeamName;
                cmbTeam2inEditMatch.SelectedItem = match.Team2TeamName;
                dtpDate.Value = match.MatchDate;
                dtpTime.Value = match.MatchTime;
                btnEditMatch.Text = "Save Changes";

            }
            else
            {

                DataGridViewRow selectedMatch = dgvEditMatch.SelectedRows[0];
                Match match = (Match)selectedMatch.DataBoundItem;
                if (db.Matches.Any(x => x.Team1 == (Team)cmbTeam1inEditMatch.SelectedItem && x.Team2 == (Team)cmbTeam2inEditMatch.SelectedItem && x.MatchDate == dtpDate.Value && x.MatchTime == dtpTime.Value&&x.Score1== (int?)nudScore1.Value&&x.Score2== (int?)nudScore2.Value)) ;
                {
                    MessageBox.Show("This Match already existed.");
                    return;
                }
                match.Team1 = (Team)cmbTeam1inEditMatch.SelectedItem;
                match.Team2 = (Team)cmbTeam2inEditMatch.SelectedItem;
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
