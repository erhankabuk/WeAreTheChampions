﻿using System;
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
            LoadAllDatabaseToDataGridViews();
        }

        private void LoadAllDatabaseToDataGridViews()
        {
            dgvColors.DataSource = db.Colors.ToList();
            dgvPlayers.DataSource = db.Players.ToList();
            cmbTeamList.DataSource = db.Teams.Select(x => x.TeamName).ToList();
            cmbTeamName.DataSource = db.Teams.Select(x => x.TeamName).ToList();



        }

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
            LoadAllDatabaseToDataGridViews();

        }

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
                editMethod();
            }



        }

        private void editMethod()
        {
            DataGridViewRow selectedColor = dgvColors.SelectedRows[0];
            Model.Color editingColor = (Model.Color)selectedColor.DataBoundItem;
            string editedColorName = txtColorName.Text.Trim();
            if (db.Colors.Any(x => x.ColorName == editedColorName))
            {
                MessageBox.Show($"{editedColorName} is already exists in database. Try another Color Name");
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
        private void btnDeleteColor_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedColor = dgvColors.SelectedRows[0];
            Model.Color editingColor = (Model.Color)selectedColor.DataBoundItem;
            db.Colors.Remove(editingColor);
            db.SaveChanges();
            dgvColors.DataSource = db.Colors.ToList();

          
        }

        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text;
            Team team = (Team)cmbTeamList.SelectedItem;

        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (cmbTeamName.SelectedItem == null)
            {
                MessageBox.Show("Please Add a New Team");
                return;
            }
        }

        private void btnAddNewTeam_Click(object sender, EventArgs e)
        {

            AddNewTeam frmAddNewTeam = new AddNewTeam(db);
            frmAddNewTeam.ShowDialog();

        }


    }
}
