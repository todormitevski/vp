namespace Airports
{
    partial class Airports
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
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnRemoveAirport = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbAvgDistance = new System.Windows.Forms.TextBox();
            this.tbMostExpensive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.lbAirports = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(12, 248);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(375, 59);
            this.btnAddAirport.TabIndex = 1;
            this.btnAddAirport.Text = "Add airport";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnRemoveAirport
            // 
            this.btnRemoveAirport.Location = new System.Drawing.Point(12, 313);
            this.btnRemoveAirport.Name = "btnRemoveAirport";
            this.btnRemoveAirport.Size = new System.Drawing.Size(375, 61);
            this.btnRemoveAirport.TabIndex = 1;
            this.btnRemoveAirport.Text = "Remove airport";
            this.btnRemoveAirport.UseVisualStyleBackColor = true;
            this.btnRemoveAirport.Click += new System.EventHandler(this.btnRemoveAirport_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(12, 380);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(375, 58);
            this.btnAddDestination.TabIndex = 1;
            this.btnAddDestination.Text = "Add destination";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbAvgDistance);
            this.groupBox3.Controls.Add(this.tbMostExpensive);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(409, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 190);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destinations";
            // 
            // tbAvgDistance
            // 
            this.tbAvgDistance.Enabled = false;
            this.tbAvgDistance.Location = new System.Drawing.Point(24, 106);
            this.tbAvgDistance.Name = "tbAvgDistance";
            this.tbAvgDistance.Size = new System.Drawing.Size(311, 20);
            this.tbAvgDistance.TabIndex = 1;
            // 
            // tbMostExpensive
            // 
            this.tbMostExpensive.Enabled = false;
            this.tbMostExpensive.Location = new System.Drawing.Point(24, 65);
            this.tbMostExpensive.Name = "tbMostExpensive";
            this.tbMostExpensive.Size = new System.Drawing.Size(311, 20);
            this.tbMostExpensive.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Average distance of all destinations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Most expensive destination";
            // 
            // lbDestinations
            // 
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.Location = new System.Drawing.Point(409, 23);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(375, 212);
            this.lbDestinations.TabIndex = 2;
            // 
            // lbAirports
            // 
            this.lbAirports.FormattingEnabled = true;
            this.lbAirports.Location = new System.Drawing.Point(12, 23);
            this.lbAirports.Name = "lbAirports";
            this.lbAirports.Size = new System.Drawing.Size(375, 212);
            this.lbAirports.TabIndex = 2;
            this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
            this.lbAirports.SelectedValueChanged += new System.EventHandler(this.lbAirports_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Airports";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Destinations";
            // 
            // Airports
            // 
            this.AcceptButton = this.btnAddAirport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbAirports);
            this.Controls.Add(this.lbDestinations);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoveAirport);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.groupBox3);
            this.Name = "Airports";
            this.Text = "Airports";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnRemoveAirport;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbAvgDistance;
        private System.Windows.Forms.TextBox tbMostExpensive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.ListBox lbAirports;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

