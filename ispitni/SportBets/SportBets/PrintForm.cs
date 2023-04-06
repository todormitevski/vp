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
    public partial class PrintForm : Form
    {
        public List<TicketForGame> Games { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalCoef { get; set; }
        public decimal Profit { get; set; }

        public PrintForm(List<TicketForGame> games, decimal amount, decimal totalCoef, decimal profit)
        {
            InitializeComponent();
            Games = games;
            Amount = amount;
            TotalCoef = totalCoef;
            Profit = profit;
        }


    }
}
