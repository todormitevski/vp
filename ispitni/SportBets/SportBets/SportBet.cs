using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportBets
{
    public partial class SportBet : Form
    {
        public decimal TotalCoef { get; set; } = 1;
        public decimal Profit { get; set; } = 1;
        public SportBet()
        {
            InitializeComponent();
            lbTeams.Items.Add(new Team("SKT T1", "KR"));
            lbTeams.Items.Add(new Team("DWG KIA", "KR"));
            lbTeams.Items.Add(new Team("Gen.G", "KR"));
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            TeamForm teamForm = new TeamForm();
            if(teamForm.ShowDialog() == DialogResult.OK)
            {
                lbTeams.Items.Add(teamForm.createdTeam);
            }
        }

        private void resetLeftMenu()
        {
            lbTeams.SelectedItems.Clear();
            numericUpDown1.Value = (decimal)1.0;
            numericUpDown2.Value = (decimal)1.0;
            numericUpDown3.Value = (decimal)1.0;
            mtbCode.Clear();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            foreach (Game game in lbGames.Items)
            {
                if (game.gameCode.Equals(mtbCode.Text))
                    return;
            }
            if (lbTeams.SelectedItems.Count == 2 && mtbCode.Text.Length == 4)
            {
                Team homeTeam = lbTeams.SelectedItems[0] as Team;
                Team awayTeam = lbTeams.SelectedItems[1] as Team;
                decimal coef1 = numericUpDown1.Value;
                decimal coef2 = numericUpDown2.Value;
                decimal coefX = numericUpDown3.Value;
                Game game = new Game(mtbCode.Text,homeTeam, awayTeam, coef1, coef2, coefX);
                lbGames.Items.Add(game);
                resetLeftMenu();
            }
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            lbGames.ClearSelected();
            string text = mtbCode1.Text;
            Object itemToSelect = null;
            foreach (Game game in lbGames.Items)
            {
                if (game.gameCode.Equals(text))
                {
                    itemToSelect = game;
                }
            }
            if(itemToSelect != null)
                lbGames.SelectedItem = itemToSelect;
        }

        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            if (lbGames.SelectedIndex != -1 && cbType.SelectedIndex != -1)
            {
                Game game = lbGames.SelectedItem as Game;
                string type = cbType.Text;
                lbTickets.Items.Add(new TicketForGame(game,type));
                lbGames.ClearSelected();
                mtbCode1.Clear();
                cbType.SelectedIndex = -1;
                recalculateTicket();
            }
        }

        private void recalculateTicket()
        {
            decimal totalCoef = (decimal)1.0;
            foreach (TicketForGame ticketForGame in lbTickets.Items)
            {
                totalCoef *= ticketForGame.getCoef();
            }
            TotalCoef = totalCoef;
            Profit = totalCoef * nudPayment.Value;
            tbTotalCoef.Text = totalCoef.ToString();
            tbProfit.Text = (totalCoef * nudPayment.Value).ToString();
        }

        private void nudPayment_ValueChanged(object sender, EventArgs e)
        {
            recalculateTicket();
        }

        private void btnPrintStats_Click(object sender, EventArgs e)
        {
            List<TicketForGame> games = new List<TicketForGame> ();
            for(int i = 0; i < lbTickets.Items.Count; i++)
            {
                games.Add(lbTickets.Items[i] as TicketForGame);
            }
            PrintForm pf = new PrintForm(games,nudPayment.Value,TotalCoef,Profit);
            pf.ShowDialog();

        }
    }
}
