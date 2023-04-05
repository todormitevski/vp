using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airports
{
    public partial class AddAirport : Form
    {
        public Airport airport { get; set; }
        public AddAirport()
        {
            InitializeComponent();
        }

        private void tbCity_Validating(object sender, CancelEventArgs e)
        {
            if(tbCity.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(tbCity, "City field cannot be empty.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbCity, null);
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Name field cannot be empty.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbName, null);
            }
        }

        private void tbShortName_Validating(object sender, CancelEventArgs e)
        {
            if(tbShortName.Text.Length == 3)
            {
                bool AllUpperLetter = true;
                foreach (char c in tbShortName.Text)
                {
                    if (Char.IsLower(c) || !Char.IsLetter(c))
                    {
                        AllUpperLetter = false;
                        break;
                    }
                }
                if (AllUpperLetter)
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbShortName, null);
                }
                else
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbShortName, "All characters must be upepr case.");
                }
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(tbShortName, "Code must be only 3 letters.");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.airport = new Airport(tbShortName.Text, tbName.Text, tbCity.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
