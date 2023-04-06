using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculty
{
    public partial class AddStudentForm : Form
    {
        public Student student { get; set; }
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            this.student = new Student(tbFullName.Text,tbIndex.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tbFullName_Validating(object sender, CancelEventArgs e)
        {
            if (tbFullName.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFullName, "Name field must be filled");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbFullName, null);
            }
        }

        private void tbIndex_Validating(object sender, CancelEventArgs e)
        {
            if (tbIndex.Text.Length != 6)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbIndex, "Index must be 6 digits long");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbIndex, null);
            }
        }
    }
}
