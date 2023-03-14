using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace SportsBets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAddToGames_Click(object sender, EventArgs e)
        {
            if(lbTeams.SelectedItems.Count == 2)
            {
                Team team1 = lbTeams.SelectedItems[0] as Team;
                Team team2 = lbTeams.SelectedItems[1] as Team;
                if(team1.Country != team2.Country)
                {
                    MessageBox.Show("Teams need to be from the same country!");
                }
                else
                {
                    Game game = new Game(mtbCode.Text,team1,team2,nudCoef1.Value,nudCoefX.Value,nudCoef2.Value);
                    lbGames.Items.Add(game);
                    lbTeams.ClearSelected();
                    nudCoef1.Value = 1.0M;
                    nudCoefX.Value = 1.0M;
                    nudCoef2.Value = 1.0M;
                    mtbCode.Clear();
                }
            }
            else
            {
                MessageBox.Show("You must select 2 teams!");
            }
        }

        private void btnAddNewTeam_Click(object sender, EventArgs e)
        {
            TeamForm teamForm = new TeamForm();
            DialogResult result = teamForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                lbTeams.Items.Add(teamForm.CreatedTeam);
            }
        }
        void recalculateCoefficients()
        {

        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {

        }

        private void nudPayment_ValueChanged(object sender, EventArgs e)
        {
            recalculateCoefficients();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void nudPayment_KeyUp(object sender, KeyEventArgs e)
        {
            recalculateCoefficients();
        }
    }
}
