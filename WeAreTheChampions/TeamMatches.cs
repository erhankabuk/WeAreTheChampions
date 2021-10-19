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
    public partial class TeamMatches : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public TeamMatches(WeAreTheChampionsContext db)
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
            cmbTeam1inMatch.DataSource = db.Teams.ToList();
            cmbTeam2inMatch.DataSource = db.Teams.ToList();
        }
        /// <summary>
        /// Add a new Match
        /// </summary>
        private void btnAddNewMatch_Click(object sender, EventArgs e)
        {
            DateTime matchDate = dtpDate.Value;
            DateTime matchTime = dtpTime.Value;
            Team team1 = (Team)cmbTeam1inMatch.SelectedItem;
            Team team2 = (Team)cmbTeam2inMatch.SelectedItem;
            db.Matches.Add(new Match()
            {
                Team1 = team1,
                Team2 = team2,
                MatchDate = matchDate,
                MatchTime = matchTime,
                Score1 = null,
                Score2 = null
            });
            db.SaveChanges();
            dgvCreateMatch.DataSource = db.Matches.ToList();
        }
    }
}
