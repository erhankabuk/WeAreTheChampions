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
            LoadAllData();
        }
        /// <summary>
        /// Load All Data
        /// </summary>
        private void LoadAllData()
        {
            dgvEditMatch.DataSource = db.Matches.ToList();
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
                txtEditedTeam1.Text = match.Team1TeamName;
                txtEditedTeam2.Text = match.Team2TeamName;
                dtpDate.Value = match.MatchDate;
                dtpTime.Value = match.MatchTime;                
                btnEditMatch.Text = "Save Changes";

            }
            else
            {
                DataGridViewRow selectedMatch = dgvEditMatch.SelectedRows[0];
                Match match = (Match)selectedMatch.DataBoundItem;
                //aynı takımların ilerde aynı saatte maçları varmı ifle bak
                match.MatchDate = dtpDate.Value;
                match.MatchTime = dtpTime.Value;
                match.Score1 = (int?)nudScore1.Value;
                match.Score2 = (int?)nudScore2.Value;
                btnEditMatch.Text = "Edit Match";
                db.SaveChanges();
                txtEditedTeam1.Clear();
                txtEditedTeam2.Clear();
                dgvEditMatch.DataSource = db.Matches.ToList();
            }
        }
    }
}
