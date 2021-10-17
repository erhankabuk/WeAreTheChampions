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
        {//Migration yap
            InitializeComponent();
            LoadAllDatabase();
        }
        /// <summary>
        ///  Load all datas
        /// </summary>
        private void LoadAllDatabase()
        {
            dgvPlayers.DataSource = db.Players.ToList();
            dgvColors.DataSource = db.Colors.ToList();
            dgvTeams.DataSource = db.Teams.ToList();
            cmbTeamList.DataSource = db.Teams.ToList();
            cmbTeamName.DataSource = db.Teams.ToList();
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
            LoadAllDatabase();

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
            if (db.Colors.Any(x => x.ColorName == editedColorName))
            {
                MessageBox.Show($"{editedColorName} is already exists in database. Try another Color Name");
                return;
            }
            if (editedColorName == string.Empty)
            {
                MessageBox.Show("Please Enter a Player Name");
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
        /// <summary>
        /// Delete player by player name
        /// </summary>    
        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedPlayer = dgvPlayers.SelectedRows[0];
            Player deletedPlayer = (Player)selectedPlayer.DataBoundItem;
            db.Players.Remove(deletedPlayer);
            //datagridview focus.
            dgvPlayers.Focus();
            db.SaveChanges();
            dgvPlayers.DataSource = db.Players.ToList();
        }

        
        private void btnAddNewTeam_Click(object sender, EventArgs e)
        {

            AddNewTeam frmAddNewTeam = new AddNewTeam(db);
            frmAddNewTeam.ShowDialog();

        }
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (cmbTeamName.SelectedItem == null)
            {
                MessageBox.Show("Please Add a New Team");
                return;
            }
        }
    }
}
