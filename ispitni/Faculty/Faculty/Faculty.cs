using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Faculty
{
    public partial class Faculty : Form
    {
        public Faculty()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm frm = new AddStudentForm();
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                lbStudents.Items.Add(frm.student);
            }
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            if(lbStudents.SelectedIndex != -1)
            {
                Student selectedStudent = lbStudents.SelectedItem as Student;
                if(selectedStudent.Grades.Count >= 10)
                {
                    return;
                }
                if (nudGrade.Value != 5)
                {
                    selectedStudent.Grades.Add((int)nudGrade.Value);
                }
                LoadStats();
            }
        }

        private void btnRemoveGrades_Click(object sender, EventArgs e)
        {
            if (lbStudents.SelectedIndex != -1)
            {
                Student selectedStudent = lbStudents.SelectedItem as Student;
                selectedStudent.Grades.Clear();
                LoadStats();
            }
        }

        private void LoadStats()
        {
            if(lbStudents.SelectedItem != null)
            {
                Student selectedStudent = lbStudents.SelectedItem as Student;
                int startMin = 10;
                int min = 0;
                int avg = 0;
                int max = 0;
                foreach (int grade in selectedStudent.Grades)
                {
                    avg += grade;
                    if(grade < startMin)
                    {
                        min = grade;
                    }
                    if(grade > max)
                    {
                        max = grade;
                    }
                }
                if (selectedStudent.Grades.Count == 0)
                {
                    avg = 5;
                }
                else avg /= selectedStudent.Grades.Count;
                string text = $"Name: {selectedStudent.FullName}\n" +
                    $"Index: {selectedStudent.Index}\n" +
                    $"Number of grades: {selectedStudent.Grades.Count}\n" +
                    $"Minimum grade: {min}\n" +
                    $"Average grade: {avg}\n" +
                    $"Maximum grade: {max}\n";
                lbStudentInfo.Text = text;

                if (rbHighestGPA.Checked)
                {
                    tbMostPassedExams.Clear();
                    double highestGPA = 0;
                    string studentToShow = "";
                    foreach(Student student in lbStudents.Items)
                    {
                        if(student.Grades.Count > 0)
                        {
                            if (student.Grades.Average() > highestGPA)
                            {
                                highestGPA = student.Grades.Average();
                                studentToShow = student.ToString();
                            }
                        }
                    }
                    tbHighestGPA.Text = $"{studentToShow}, with {highestGPA} GPA";
                }

                if (rbMostPassedExams.Checked)
                {
                    tbHighestGPA.Clear();
                    int maxPassed = 0;
                    string studentToShow = "";
                    foreach(Student student in lbStudents.Items)
                    {
                        if (student.Grades.Count > maxPassed)
                        {
                            maxPassed = student.Grades.Count;
                            studentToShow = student.ToString();
                        }
                    }
                    tbMostPassedExams.Text = $"{studentToShow}, with {maxPassed} passed exams";
                }
            }
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStats();
        }

        private void lbStudents_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadStats();
        }

        private void rbHighestGPA_CheckedChanged(object sender, EventArgs e)
        {
            LoadStats();
        }

        private void rbMostPassedExams_CheckedChanged(object sender, EventArgs e)
        {
            LoadStats();
        }
    }
}
