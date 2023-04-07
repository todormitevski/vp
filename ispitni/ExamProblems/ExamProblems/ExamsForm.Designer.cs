namespace ExamProblems
{
    partial class ExamsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.btnRemoveExam = new System.Windows.Forms.Button();
            this.lbExams = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveQ1 = new System.Windows.Forms.Button();
            this.nudQ1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQ1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveQ2 = new System.Windows.Forms.Button();
            this.tbQ2 = new System.Windows.Forms.TextBox();
            this.nudQ2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQ1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQ2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddExam);
            this.groupBox1.Controls.Add(this.btnRemoveExam);
            this.groupBox1.Controls.Add(this.lbExams);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 488);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exams";
            // 
            // btnAddExam
            // 
            this.btnAddExam.Location = new System.Drawing.Point(6, 417);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(255, 23);
            this.btnAddExam.TabIndex = 1;
            this.btnAddExam.Text = "Add Exam";
            this.btnAddExam.UseVisualStyleBackColor = true;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // btnRemoveExam
            // 
            this.btnRemoveExam.Location = new System.Drawing.Point(6, 446);
            this.btnRemoveExam.Name = "btnRemoveExam";
            this.btnRemoveExam.Size = new System.Drawing.Size(255, 23);
            this.btnRemoveExam.TabIndex = 1;
            this.btnRemoveExam.Text = "Remove Exam";
            this.btnRemoveExam.UseVisualStyleBackColor = true;
            this.btnRemoveExam.Click += new System.EventHandler(this.btnRemoveExam_Click);
            // 
            // lbExams
            // 
            this.lbExams.FormattingEnabled = true;
            this.lbExams.Location = new System.Drawing.Point(7, 20);
            this.lbExams.Name = "lbExams";
            this.lbExams.Size = new System.Drawing.Size(255, 381);
            this.lbExams.TabIndex = 0;
            this.lbExams.SelectedIndexChanged += new System.EventHandler(this.lbExams_SelectedIndexChanged);
            this.lbExams.SelectedValueChanged += new System.EventHandler(this.lbExams_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveQ1);
            this.groupBox2.Controls.Add(this.nudQ1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbQ1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(293, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 241);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exam Question 1";
            // 
            // btnSaveQ1
            // 
            this.btnSaveQ1.Location = new System.Drawing.Point(163, 205);
            this.btnSaveQ1.Name = "btnSaveQ1";
            this.btnSaveQ1.Size = new System.Drawing.Size(99, 30);
            this.btnSaveQ1.TabIndex = 4;
            this.btnSaveQ1.Text = "Save";
            this.btnSaveQ1.UseVisualStyleBackColor = true;
            this.btnSaveQ1.Click += new System.EventHandler(this.btnSaveQ1_Click);
            // 
            // nudQ1
            // 
            this.nudQ1.Location = new System.Drawing.Point(10, 167);
            this.nudQ1.Name = "nudQ1";
            this.nudQ1.Size = new System.Drawing.Size(120, 20);
            this.nudQ1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Points:";
            // 
            // tbQ1
            // 
            this.tbQ1.Location = new System.Drawing.Point(10, 37);
            this.tbQ1.Multiline = true;
            this.tbQ1.Name = "tbQ1";
            this.tbQ1.Size = new System.Drawing.Size(252, 106);
            this.tbQ1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveQ2);
            this.groupBox3.Controls.Add(this.tbQ2);
            this.groupBox3.Controls.Add(this.nudQ2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(293, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 241);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exam Question 2";
            // 
            // btnSaveQ2
            // 
            this.btnSaveQ2.Location = new System.Drawing.Point(163, 204);
            this.btnSaveQ2.Name = "btnSaveQ2";
            this.btnSaveQ2.Size = new System.Drawing.Size(99, 30);
            this.btnSaveQ2.TabIndex = 4;
            this.btnSaveQ2.Text = "Save";
            this.btnSaveQ2.UseVisualStyleBackColor = true;
            this.btnSaveQ2.Click += new System.EventHandler(this.btnSaveQ2_Click);
            // 
            // tbQ2
            // 
            this.tbQ2.Location = new System.Drawing.Point(10, 36);
            this.tbQ2.Multiline = true;
            this.tbQ2.Name = "tbQ2";
            this.tbQ2.Size = new System.Drawing.Size(252, 106);
            this.tbQ2.TabIndex = 1;
            // 
            // nudQ2
            // 
            this.nudQ2.Location = new System.Drawing.Point(10, 166);
            this.nudQ2.Name = "nudQ2";
            this.nudQ2.Size = new System.Drawing.Size(120, 20);
            this.nudQ2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Points:";
            // 
            // ExamsForm
            // 
            this.AcceptButton = this.btnAddExam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 513);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExamsForm";
            this.Text = "Exams";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQ1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQ2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.Button btnRemoveExam;
        private System.Windows.Forms.ListBox lbExams;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveQ1;
        private System.Windows.Forms.NumericUpDown nudQ1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQ1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSaveQ2;
        private System.Windows.Forms.TextBox tbQ2;
        private System.Windows.Forms.NumericUpDown nudQ2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

