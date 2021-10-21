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
    public partial class Form1 : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();

        public Form1()
        {
            InitializeComponent();
            dgvMatches.AutoGenerateColumns = false;
            dgvPlayers.AutoGenerateColumns = false;
            dgvColors.AutoGenerateColumns = false;
            dgvTeams.AutoGenerateColumns = false;

            LoadAllDatabase();
        }
        /// <summary>
        ///  Load all data
        /// </summary>
        private void LoadAllDatabase()
        {
            dgvMatches.DataSource = db.Matches.ToList();
            dgvPlayers.DataSource = db.Players.ToList();
            dgvColors.DataSource = db.Colors.ToList();
            dgvTeams.DataSource = db.Teams.ToList();
            cmbTeamList.DataSource = db.Teams.ToList();
        }

        /// <summary>
        /// Add new color
        /// </summary>        
        private void btnAddColor_Click(object sender, EventArgs e)
        {
            string colorName = txtColorName.Text;
            if (colorName == string.Empty)
            {
                MessageBox.Show("Please enter Color Name");
                return;
            }
            else if (db.Colors.Any(x => x.ColorName == colorName))
            {
                MessageBox.Show($"{colorName} is already exists in database. Try another Color Name");
                return;
            }
            db.Colors.Add(new Model.Color() { ColorName = colorName, Red = (int)nudRed.Value, Green = (int)nudGreen.Value, Blue = (int)nudBlue.Value });
            db.SaveChanges();
            dgvColors.DataSource = db.Colors.ToList();
        }

        /// <summary>
        /// Edit color
        /// </summary>        
        private void btnEditColor_Click(object sender, EventArgs e)
        {
            if (btnEditColor.Text == "Edit Color")
            {
                if (dgvColors.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a color for editing.");
                    return;
                }
                DataGridViewRow selectedColor = dgvColors.SelectedRows[0];
                Model.Color editingColor = (Model.Color)selectedColor.DataBoundItem;
                txtColorName.Text = editingColor.ColorName;
                nudRed.Value = editingColor.Red;
                nudGreen.Value = editingColor.Green;
                nudBlue.Value = editingColor.Blue;
                btnEditColor.Text = "Save Changes";
                btnAddColor.Enabled = false;
                btnDeleteColor.Enabled = false;
            }
            else
            {
                EditColor();
            }
        }
        private void EditColor()
        {
            DataGridViewRow selectedColor = dgvColors.SelectedRows[0];
            Model.Color editingColor = (Model.Color)selectedColor.DataBoundItem;
            string editedColorName = txtColorName.Text.Trim();

            if (db.Colors.Any(x => x.ColorName == editedColorName && x.Red == nudRed.Value && x.Green == nudGreen.Value && x.Blue == nudBlue.Value))
            {
                MessageBox.Show($"{editedColorName}, Red{nudRed.Value}, Green{nudGreen.Value}, Blue{nudBlue.Value} is already exists in database.");
                return;
            }
            if (editedColorName == string.Empty)
            {
                MessageBox.Show("Please Enter a Color Name");
                return;
            }
            editingColor.ColorName = editedColorName;
            editingColor.Red = (int)nudRed.Value;
            editingColor.Green = (int)nudGreen.Value;
            editingColor.Blue = (int)nudBlue.Value;
            btnAddColor.Enabled = true;
            btnDeleteColor.Enabled = true;
            btnEditColor.Text = "Edit Color";
            db.SaveChanges();
            dgvColors.DataSource = db.Colors.ToList();
        }

        /// <summary>
        /// Delete a color
        /// </summary>        
        private void btnDeleteColor_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedColor = dgvColors.SelectedRows[0];
            Model.Color deletedColor = (Model.Color)selectedColor.DataBoundItem;
            db.Colors.Remove(deletedColor);
            db.SaveChanges();
            dgvColors.DataSource = db.Colors.ToList();
        }

        /// <summary>
        /// Add a new player and team
        /// </summary>
        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text;
            if (playerName == string.Empty)
            {
                MessageBox.Show("Please Enter a Player Name");
                return;
            }
            if (db.Players.Any(x => x.PlayerName == playerName))
            {
                MessageBox.Show($"{playerName} is already existed in database. Try another Player Name");
                return;
            }

            Team team = (Team)cmbTeamList.SelectedItem;
            Player player = new Player();
            player.PlayerName = playerName;
            if (chkTeamMember.Checked == false)
                db.Players.Add(new Player() { PlayerName = playerName });
            else
                db.Players.Add(new Player() { PlayerName = playerName, TeamId = team.Id });

            db.SaveChanges();
            txtPlayerName.Clear();
            dgvPlayers.DataSource = db.Players.ToList();
        }

        /// <summary>
        /// Edit player name and team
        /// </summary>
        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
            if (btnEditPlayer.Text == "Edit Player")
            {
                if (dgvPlayers.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a player for editing.");
                    return;
                }
                dgvPlayers.Enabled = false;
                DataGridViewRow selectedPlayer = dgvPlayers.SelectedRows[0];
                Player editingPlayer = (Player)selectedPlayer.DataBoundItem;
                txtPlayerName.Text = editingPlayer.PlayerName;
                // todo:comboboxta  herzaman null seçili olsun
                btnEditPlayer.Text = "Save Changes";
                btnAddNewPlayer.Enabled = false;
                btnDeletePlayer.Enabled = false;

            }
            else
            {
                EditPlayer();
            }
        }
        private void chkTeamMember_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTeamMember.Checked == false)
                cmbTeamList.Enabled = false;
            else
                cmbTeamList.Enabled = true;
        }
        private void EditPlayer()
        {
            DataGridViewRow selectedPlayer = dgvPlayers.SelectedRows[0];
            Player editingPlayer = (Player)selectedPlayer.DataBoundItem;
            string editedPlayerName = txtPlayerName.Text.Trim();
            Team team = (Team)cmbTeamList.SelectedItem;
            if (editedPlayerName == string.Empty)
            {
                MessageBox.Show("Please Enter a Player Name");
                return;
            }
            if (editingPlayer.PlayerName != editedPlayerName && db.Players.Any(x => x.PlayerName == editedPlayerName))
            {
                MessageBox.Show($"{editedPlayerName} is already existed. Try Another New Player Name");
                return;
            }

            if (chkTeamMember.Checked == false)
            {
                cmbTeamList.Enabled = false;
                editingPlayer.PlayerName = editedPlayerName;
                editingPlayer.TeamId = null;
                btnEditPlayer.Text = "Edit Player";
                btnAddNewPlayer.Enabled = true;
                btnDeletePlayer.Enabled = true;
                dgvPlayers.Enabled = true;
                db.SaveChanges();
                txtPlayerName.Clear();
                dgvPlayers.DataSource = db.Players.ToList();

            }
            else
            {
                cmbTeamList.Enabled = true;
                editingPlayer.PlayerName = editedPlayerName;
                editingPlayer.TeamId = team.Id;
                btnEditPlayer.Text = "Edit Player";
                btnAddNewPlayer.Enabled = true;
                btnDeletePlayer.Enabled = true;
                dgvPlayers.Enabled = true;
                db.SaveChanges();
                txtPlayerName.Clear();
                dgvPlayers.DataSource = db.Players.ToList();

            }

        }

        /// <summary>
        /// Delete player by player name
        /// </summary>    
        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedPlayer = dgvPlayers.SelectedRows[0];
            Player deletedPlayer = (Player)selectedPlayer.DataBoundItem;
            db.Players.Remove(deletedPlayer);
            db.SaveChanges();
            dgvPlayers.DataSource = db.Players.ToList();
        }

        /// <summary>
        /// Delete a Match 
        /// </summary>
        private void btnDeleteMatch_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedMatch = dgvMatches.SelectedRows[0];
            Match match = (Match)selectedMatch.DataBoundItem;
            db.Matches.Remove(match);
            db.SaveChanges();
            dgvMatches.DataSource = db.Matches.ToList();
        }

        /// <summary>
        /// Hide&Show Played Matches
        /// </summary>
        private void btnHidePlayedMatch_Click(object sender, EventArgs e)
        {
            if (btnHidePlayedMatch.Text == "Hide Played Matches")
            {
                dgvMatches.DataSource = null;
                dgvMatches.DataSource = db.Matches.Except(db.Matches.Where(x => x.Score1 != null || x.Score2 != null)).ToList();
                btnHidePlayedMatch.Text = "Show All Matches";
            }
            else
            {
                dgvMatches.DataSource = null;
                dgvMatches.DataSource = db.Matches.ToList();
                btnHidePlayedMatch.Text = "Hide Played Matches";
            }
        }

        private void btnAddNewTeam_Click(object sender, EventArgs e)
        {
            TeamCreate frmTeam = new TeamCreate(db);
            frmTeam.ShowDialog();
            dgvTeams.DataSource = db.Teams.ToList();

        }
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            TeamPlayers frmAddNewPlayer = new TeamPlayers(db);
            frmAddNewPlayer.ShowDialog();
            dgvTeams.DataSource = db.Teams.ToList();
        }
        private void btnAddTeamColor_Click(object sender, EventArgs e)
        {
            FrmTeamColor frmTeamColor = new FrmTeamColor(db);
            frmTeamColor.ShowDialog();
            dgvTeams.DataSource = db.Teams.ToList();
        }
        private void btnAddNewMatch_Click(object sender, EventArgs e)
        {
            TeamMatches frmTeamMatches = new TeamMatches(db);
            frmTeamMatches.ShowDialog();
            dgvMatches.DataSource = db.Matches.ToList();
        }
        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            TeamEditMatch frmEditMatch = new TeamEditMatch(db);
            frmEditMatch.ShowDialog();
            dgvMatches.DataSource = db.Matches.ToList();
        }
        private void dgvMatches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TeamEditMatch frmEditMatch = new TeamEditMatch(db);
            frmEditMatch.ShowDialog();
            dgvMatches.DataSource = db.Matches.ToList();
        }

    }
}


