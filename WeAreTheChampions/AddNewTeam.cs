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
    public partial class AddNewTeam : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public AddNewTeam(WeAreTheChampionsContext db)
        {
            this.db = db;
            InitializeComponent();
            LoadAllTeams();
        }

        private void LoadAllTeams()
        {
            dgvAddANetTeam.DataSource = db.Teams.ToList();
           
        }

        private void btnCreateNewTeam_Click(object sender, EventArgs e)
        {
            string createNewTeam = txtAddNewTeam.Text;
            if (createNewTeam==string.Empty)
            {
                MessageBox.Show("Please Enter New Team Name");
                return;
            }
            if( db.Teams.Any(x=>x.TeamName==createNewTeam))
               {
                MessageBox.Show($"{createNewTeam} is already exists. Try Another New Team Name");
                return;
            }
            db.Teams.Add(new Team() { TeamName=createNewTeam});
            LoadAllTeams();
        }
    }
}
