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
    public partial class TeamPlayers : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public TeamPlayers(WeAreTheChampionsContext db)
        {
            this.db = db;            
            InitializeComponent();
            dgvTeamPlayersinTeam.AutoGenerateColumns = false;
            LoadAllData();
        }

        /// <summary>
        /// Load All Data
        /// </summary>
        private void LoadAllData()
        {
            dgvTeamPlayersinTeam.DataSource = db.Players.ToList();
            List<Player> list = new List<Player>();           
            list.AddRange(db.Players.Where(x => x.TeamId ==null));
            cmbPlayersinTeamPlayers.DataSource = list;
            cmbTeamsinTeamPlayers.DataSource = db.Teams.ToList();
        }

        /// <summary>
        /// Add Player to a Team
        /// </summary>
        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
           
            Player player = (Player)cmbPlayersinTeamPlayers.SelectedItem;                       
            Team team = (Team)cmbTeamsinTeamPlayers.SelectedItem;
            player.TeamId = team.Id;           
            db.SaveChanges();
            dgvTeamPlayersinTeam.DataSource = db.Players.ToList();
        }

        /// <summary>
        /// Remove a Player From a Team
        /// </summary>
        private void btnRemoveTeamPlayer_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedPlayer = dgvTeamPlayersinTeam.SelectedRows[0];
            Player player = (Player)selectedPlayer.DataBoundItem;
            player.TeamId = null;
            db.SaveChanges();
            List<Player> list = new List<Player>();
            list.AddRange(db.Players.Where(x => x.TeamId == null));
            cmbPlayersinTeamPlayers.DataSource = list;
            dgvTeamPlayersinTeam.DataSource = db.Players.ToList();
        }
       

    }
}
