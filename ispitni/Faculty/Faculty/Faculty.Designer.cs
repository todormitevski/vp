namespace Faculty
{
    partial class Faculty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveGrades = new System.Windows.Forms.Button();
            this.nudGrade = new System.Windows.Forms.NumericUpDown();
            this.btnAddGrade = new System.Windows.Forms.Button();
            this.rbHighestGPA = new System.Windows.Forms.RadioButton();
            this.rbMostPassedExams = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbStudentInfo = new System.Windows.Forms.Label();
            this.tbHighestGPA = new System.Windows.Forms.TextBox();
            this.tbMostPassedExams = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(13, 13);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(221, 316);
            this.lbStudents.TabIndex = 0;
            this.lbStudents.SelectedIndexChanged += new System.EventHandler(this.lbStudents_SelectedIndexChanged);
            this.lbStudents.SelectedValueChanged += new System.EventHandler(this.lbStudents_SelectedValueChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(13, 363);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(221, 23);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Add student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveGrades
            // 
            this.btnRemoveGrades.Location = new System.Drawing.Point(13, 392);
            this.btnRemoveGrades.Name = "btnRemoveGrades";
            this.btnRemoveGrades.Size = new System.Drawing.Size(221, 23);
            this.btnRemoveGrades.TabIndex = 1;
            this.btnRemoveGrades.Text = "Delete grades";
            this.btnRemoveGrades.UseVisualStyleBackColor = true;
            this.btnRemoveGrades.Click += new System.EventHandler(this.btnRemoveGrades_Click);
            // 
            // nudGrade
            // 
            this.nudGrade.Location = new System.Drawing.Point(268, 13);
            this.nudGrade.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGrade.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudGrade.Name = "nudGrade";
            this.nudGrade.Size = new System.Drawing.Size(120, 20);
            this.nudGrade.TabIndex = 2;
            this.nudGrade.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnAddGrade
            // 
            this.btnAddGrade.Location = new System.Drawing.Point(268, 39);
            this.btnAddGrade.Name = "btnAddGrade";
            this.btnAddGrade.Size = new System.Drawing.Size(120, 23);
            this.btnAddGrade.TabIndex = 3;
            this.btnAddGrade.Text = "Add grade";
            this.btnAddGrade.UseVisualStyleBackColor = true;
            this.btnAddGrade.Click += new System.EventHandler(this.btnAddGrade_Click);
            // 
            // rbHighestGPA
            // 
            this.rbHighestGPA.AutoSize = true;
            this.rbHighestGPA.Location = new System.Drawing.Point(268, 218);
            this.rbHighestGPA.Name = "rbHighestGPA";
            this.rbHighestGPA.Size = new System.Drawing.Size(86, 17);
            this.rbHighestGPA.TabIndex = 4;
            this.rbHighestGPA.TabStop = true;
            this.rbHighestGPA.Text = "Highest GPA";
            this.rbHighestGPA.UseVisualStyleBackColor = true;
            this.rbHighestGPA.CheckedChanged += new System.EventHandler(this.rbHighestGPA_CheckedChanged);
            // 
            // rbMostPassedExams
            // 
            this.rbMostPassedExams.AutoSize = true;
            this.rbMostPassedExams.Location = new System.Drawing.Point(268, 241);
            this.rbMostPassedExams.Name = "rbMostPassedExams";
            this.rbMostPassedExams.Size = new System.Drawing.Size(118, 17);
            this.rbMostPassedExams.TabIndex = 4;
            this.rbMostPassedExams.TabStop = true;
            this.rbMostPassedExams.Text = "Most passed exams";
            this.rbMostPassedExams.UseVisualStyleBackColor = true;
            this.rbMostPassedExams.CheckedChanged += new System.EventHandler(this.rbMostPassedExams_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Information for selected student:";
            // 
            // lbStudentInfo
            // 
            this.lbStudentInfo.AutoSize = true;
            this.lbStudentInfo.Location = new System.Drawing.Point(268, 95);
            this.lbStudentInfo.Name = "lbStudentInfo";
            this.lbStudentInfo.Size = new System.Drawing.Size(0, 13);
            this.lbStudentInfo.TabIndex = 5;
            // 
            // tbHighestGPA
            // 
            this.tbHighestGPA.Enabled = false;
            this.tbHighestGPA.Location = new System.Drawing.Point(392, 217);
            this.tbHighestGPA.Name = "tbHighestGPA";
            this.tbHighestGPA.Size = new System.Drawing.Size(222, 20);
            this.tbHighestGPA.TabIndex = 6;
            // 
            // tbMostPassedExams
            // 
            this.tbMostPassedExams.Enabled = false;
            this.tbMostPassedExams.Location = new System.Drawing.Point(392, 240);
            this.tbMostPassedExams.Name = "tbMostPassedExams";
            this.tbMostPassedExams.Size = new System.Drawing.Size(222, 20);
            this.tbMostPassedExams.TabIndex = 6;
            // 
            // Faculty
            // 
            this.AcceptButton = this.btnAddStudent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.tbMostPassedExams);
            this.Controls.Add(this.tbHighestGPA);
            this.Controls.Add(this.lbStudentInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbMostPassedExams);
            this.Controls.Add(this.rbHighestGPA);
            this.Controls.Add(this.btnAddGrade);
            this.Controls.Add(this.nudGrade);
            this.Controls.Add(this.btnRemoveGrades);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lbStudents);
            this.Name = "Faculty";
            this.Text = "Faculty";
            ((System.ComponentModel.ISupportInitialize)(this.nudGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveGrades;
        private System.Windows.Forms.NumericUpDown nudGrade;
        private System.Windows.Forms.Button btnAddGrade;
        private System.Windows.Forms.RadioButton rbHighestGPA;
        private System.Windows.Forms.RadioButton rbMostPassedExams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStudentInfo;
        private System.Windows.Forms.TextBox tbHighestGPA;
        private System.Windows.Forms.TextBox tbMostPassedExams;
    }
}

