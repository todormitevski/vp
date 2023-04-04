using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SportsBets
{
    public partial class PrintForm : Form
    {
        public List<Ticket> Games { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalCoef { get; set; }
        public decimal Profit { get; set; }

        public PrintForm(List<Ticket> games, decimal amount, decimal totalCoef, decimal profit)
        {
            InitializeComponent();
            Games = games;
            Amount = amount;
            TotalCoef = totalCoef;
            Profit = profit;

            lblCoef.Text = TotalCoef.ToString();
            lblUplata.Text = Amount.ToString();
            lblDobivka.Text = Profit.ToString();
            decimal tax = profit * 0.10M;
            lblDanok.Text = tax.ToString();
        }

        public PrintForm()
        {
            InitializeComponent();
        }
        public void init()
        {

        }
           

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PrintForm_Load(object sender, EventArgs e)
        {

        }
    }
}
