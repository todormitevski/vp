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
        public decimal TotalCoef { get; set; } = 1;
        public decimal Profit { get; set; } = 1;

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
            if (lbGames.SelectedIndex != -1 && cbTip.SelectedIndex != -1)
            {
                Game game = lbGames.SelectedItem as Game;
                int type = cbTip.Text == "1" ? 0 : (cbTip.Text == "X" ? 1 : 2);
                Ticket ticket = new Ticket(game, type);
                lbTickets.Items.Add(ticket);
                lbGames.ClearSelected();
                tbCodeToEnter.Clear();
                updateMoneyData();
            }
        }

        private void nudPayment_ValueChanged(object sender, EventArgs e)
        {
            updateMoneyData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<Ticket> games = new List<Ticket>();
            for(int i = 0; i<lbTickets.Items.Count; i++)
            {
                games.Add(lbTickets.Items[i] as Ticket);
            }
            PrintForm printForm = new PrintForm(games,nudPayment.Value,TotalCoef,Profit);

        }

        private void nudPayment_KeyUp(object sender, KeyEventArgs e)
        {
            updateMoneyData();
        }

        private void tbCodeToEnter_TextChanged(object sender, EventArgs e)
        {
            String codeToSearch = tbCodeToEnter.Text;
            for (int i = 0; i < lbGames.Items.Count; i++)
            {
                Game game = lbGames.Items[i] as Game;
                if(game.Code == codeToSearch)
                {
                    lbGames.SelectedIndex = i;
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbTeams.Items.Add(new Team("Barca","Spain"));
            lbTeams.Items.Add(new Team("Real Madrid","Spain"));
        }

        private decimal recalculateCoeffs()
        {
            decimal product = 1;
            for (int i = 0; i < lbTickets.Items.Count; i++)
            {
                Ticket ticket = lbTickets.Items[i] as Ticket;
                int type = ticket.Type;
                Game game = ticket.Game;
                product *= type == 0 ? game.Coef1 : type == 1 ? game.CoefX : game.Coef2;
            }
            return product;
        }

        private void updateMoneyData()
        {
            TotalCoef = recalculateCoeffs();
            Profit = TotalCoef * nudPayment.Value;
            tbTotalCoef.Text = TotalCoef.ToString();
            tbProfit.Text = Profit.ToString();
        }

        private void lbTickets_SizeChanged(object sender, EventArgs e)
        {
            tbTotalCoef.Text = recalculateCoeffs().ToString();
        }
    }
}
