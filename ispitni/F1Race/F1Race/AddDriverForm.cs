using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Race
{
    public partial class AddDriverForm : Form
    {
        public Driver driver { get; set; }
        public AddDriverForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbName.Text != "" && nudAge.Value >= 18)
            {
                bool first = cbFirstPlace.Checked ? true : false;
                this.driver = new Driver(tbName.Text, (int)nudAge.Value, first);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text == "")
            {
                errorProvider1.SetError(tbName,"Name field must be filled");
            }
            else
            {
                errorProvider1.SetError(tbName, null);
            }
        }

        private void nudAge_Validating(object sender, CancelEventArgs e)
        {
            if(nudAge.Value < 18)
            {
                errorProvider1.SetError(nudAge,"Driver must be at least 18 years old");
            }
            else
            {
                errorProvider1.SetError(nudAge, null);
            }
        }
    }
}
