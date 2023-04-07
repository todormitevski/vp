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
    public partial class ExamsForm : Form
    {
        //Not working properly
        public List<Exam> exams = new List<Exam>();
        public ExamsForm()
        {
            InitializeComponent();
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            AddExamForm form = new AddExamForm();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                lbExams.Items.Add(form.exam);
            }
        }

        private void btnRemoveExam_Click(object sender, EventArgs e)
        {
            if(lbExams.SelectedIndex != -1)
            {
                Exam selectedExam = lbExams.SelectedItem as Exam;
                lbExams.Items.Remove(selectedExam);
                LoadQuestions(selectedExam);
            }
        }

        private void btnSaveQ1_Click(object sender, EventArgs e)
        {
            if(tbQ1.Text != "" && nudQ1.Value > 0 && lbExams.SelectedIndex != -1)
            {
                Exam selectedExam = lbExams.SelectedItem as Exam;
                selectedExam.Q1 = new Question(tbQ1.Text,(int)nudQ1.Value);
            }
        }

        private void btnSaveQ2_Click(object sender, EventArgs e)
        {
            if(tbQ2.Text != "" && nudQ2.Value > 0 && lbExams.SelectedIndex != -1)
            {
                Exam selectedExam = lbExams.SelectedItem as Exam;
                selectedExam.Q2 = new Question(tbQ1.Text,(int)nudQ1.Value);
            }
        }

        private void LoadQuestions(Exam Exam)
        {
            if(lbExams.SelectedIndex != -1)
            {
                Exam exam = lbExams.SelectedItem as Exam;
                if(exam.Q1 != null)
                {
                    tbQ1.Text = exam.Q1.Description;
                    nudQ1.Value = exam.Q1.Points;
                }
                if(exam.Q2 != null)
                {
                    tbQ2.Text = exam.Q2.Description;
                    nudQ2.Value = exam.Q2.Points;
                }
            }
            else
            {
                tbQ1.Text = "";
                nudQ1.Value = 0;
            }
        }

        private void lbExams_SelectedIndexChanged(object sender, EventArgs e)
        {
            Exam exam = lbExams.SelectedItem as Exam;
            LoadQuestions(exam);
        }

        private void lbExams_SelectedValueChanged(object sender, EventArgs e)
        {
            Exam exam = lbExams.SelectedItem as Exam;
            LoadQuestions(exam);
        }
    }
}
