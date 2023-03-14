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
    public partial class TeamForm : Form
    {
        public Team CreatedTeam { get; set; }

        public TeamForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1();
            CreatedTeam = new Team(tbName.Text, tbCountry.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void TeamForm_Load(object sender, EventArgs e)
        {

        }
    }
}
