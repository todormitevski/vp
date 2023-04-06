namespace TVProgrammes
{
    partial class TVProgrammesForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChannel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProgramName = new System.Windows.Forms.TextBox();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteProgram = new System.Windows.Forms.Button();
            this.btnAddProgram = new System.Windows.Forms.Button();
            this.btnAddChannel = new System.Windows.Forms.Button();
            this.lblProgramToShow = new System.Windows.Forms.Label();
            this.lbProgrammes = new System.Windows.Forms.ListBox();
            this.tbAverageDuration = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddProgram);
            this.groupBox1.Controls.Add(this.btnDeleteProgram);
            this.groupBox1.Controls.Add(this.nudDuration);
            this.groupBox1.Controls.Add(this.tbProgramName);
            this.groupBox1.Controls.Add(this.cbChannel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New show";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbAverageDuration);
            this.groupBox2.Controls.Add(this.lbProgrammes);
            this.groupBox2.Controls.Add(this.lblProgramToShow);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(345, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 356);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program on Channel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Channel:";
            // 
            // cbChannel
            // 
            this.cbChannel.FormattingEnabled = true;
            this.cbChannel.Location = new System.Drawing.Point(22, 50);
            this.cbChannel.Name = "cbChannel";
            this.cbChannel.Size = new System.Drawing.Size(281, 21);
            this.cbChannel.TabIndex = 2;
            this.cbChannel.SelectedIndexChanged += new System.EventHandler(this.cbChannel_SelectedIndexChanged);
            this.cbChannel.SelectedValueChanged += new System.EventHandler(this.cbChannel_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // tbProgramName
            // 
            this.tbProgramName.Location = new System.Drawing.Point(22, 101);
            this.tbProgramName.Name = "tbProgramName";
            this.tbProgramName.Size = new System.Drawing.Size(281, 20);
            this.tbProgramName.TabIndex = 3;
            this.tbProgramName.TextChanged += new System.EventHandler(this.tbProgramName_TextChanged);
            // 
            // nudDuration
            // 
            this.nudDuration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDuration.Location = new System.Drawing.Point(22, 151);
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(120, 20);
            this.nudDuration.TabIndex = 4;
            this.nudDuration.ValueChanged += new System.EventHandler(this.nudDuration_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Average duration:";
            // 
            // btnDeleteProgram
            // 
            this.btnDeleteProgram.Location = new System.Drawing.Point(139, 186);
            this.btnDeleteProgram.Name = "btnDeleteProgram";
            this.btnDeleteProgram.Size = new System.Drawing.Size(111, 23);
            this.btnDeleteProgram.TabIndex = 5;
            this.btnDeleteProgram.Text = "Delete program";
            this.btnDeleteProgram.UseVisualStyleBackColor = true;
            this.btnDeleteProgram.Click += new System.EventHandler(this.btnDeleteProgram_Click);
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.Enabled = false;
            this.btnAddProgram.Location = new System.Drawing.Point(22, 186);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(111, 23);
            this.btnAddProgram.TabIndex = 5;
            this.btnAddProgram.Text = "Add program";
            this.btnAddProgram.UseVisualStyleBackColor = true;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddProgram_Click);
            // 
            // btnAddChannel
            // 
            this.btnAddChannel.Location = new System.Drawing.Point(34, 345);
            this.btnAddChannel.Name = "btnAddChannel";
            this.btnAddChannel.Size = new System.Drawing.Size(111, 23);
            this.btnAddChannel.TabIndex = 5;
            this.btnAddChannel.Text = "Add Channel";
            this.btnAddChannel.UseVisualStyleBackColor = true;
            this.btnAddChannel.Click += new System.EventHandler(this.btnAddChannel_Click);
            // 
            // lblProgramToShow
            // 
            this.lblProgramToShow.AutoSize = true;
            this.lblProgramToShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramToShow.Location = new System.Drawing.Point(17, 33);
            this.lblProgramToShow.Name = "lblProgramToShow";
            this.lblProgramToShow.Size = new System.Drawing.Size(0, 31);
            this.lblProgramToShow.TabIndex = 0;
            // 
            // lbProgrammes
            // 
            this.lbProgrammes.FormattingEnabled = true;
            this.lbProgrammes.Location = new System.Drawing.Point(6, 84);
            this.lbProgrammes.Name = "lbProgrammes";
            this.lbProgrammes.Size = new System.Drawing.Size(313, 212);
            this.lbProgrammes.TabIndex = 1;
            // 
            // tbAverageDuration
            // 
            this.tbAverageDuration.Enabled = false;
            this.tbAverageDuration.Location = new System.Drawing.Point(9, 330);
            this.tbAverageDuration.Name = "tbAverageDuration";
            this.tbAverageDuration.Size = new System.Drawing.Size(310, 20);
            this.tbAverageDuration.TabIndex = 2;
            // 
            // TVProgrammesForm
            // 
            this.AcceptButton = this.btnAddChannel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 380);
            this.Controls.Add(this.btnAddChannel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TVProgrammesForm";
            this.Text = "TV Series";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProgram;
        private System.Windows.Forms.Button btnDeleteProgram;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.TextBox tbProgramName;
        private System.Windows.Forms.ComboBox cbChannel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbAverageDuration;
        private System.Windows.Forms.ListBox lbProgrammes;
        private System.Windows.Forms.Label lblProgramToShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddChannel;
    }
}

