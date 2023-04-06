using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobiles
{
    public partial class ManufacturerForm : Form
    {
        public Manufacturer manufacturer { get; set; }
        public ManufacturerForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.manufacturer = new Manufacturer(tbName.Text,tbCode.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text == "")
            {
                errorProvider1.SetError(tbName, "Name must be provided");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void tbCode_Validating(object sender, CancelEventArgs e)
        {
            if(tbCode.Text == "")
            {
                errorProvider1.SetError(tbCode, "Code must be provided");
                e.Cancel = true;
            }
            else
            {
                if (tbCode.Text.Length != 1)
                {
                    errorProvider1.SetError(tbCode, "Length must be 1");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider1.SetError(tbCode, null);
                    e.Cancel = false;
                }
            }
            
        }
    }
}
