using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProblems
{
    public partial class AddExamForm : Form
    {
        public Exam exam;
        public AddExamForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cbMonth.Text != "")
            {
                this.exam = new Exam(cbMonth.Text,(int)nudYear.Value);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cbMonth_Validating(object sender, CancelEventArgs e)
        {
            if(cbMonth.Text == "")
            {
                errorProvider1.SetError(cbMonth,"You must choose a month to proceed");
            }
            else
            {
                errorProvider1.SetError(cbMonth, null);
            }
        }

        private void nudYear_Validating(object sender, CancelEventArgs e)
        {
            if (cbMonth.Text == "")
            {
                errorProvider1.SetError(cbMonth, "You must choose a month to proceed");
            }
            else
            {
                errorProvider1.SetError(cbMonth, null);
            }
        }
    }
}
