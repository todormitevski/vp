namespace Aud4
{
    partial class Form1
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
            this.lbStrings = new System.Windows.Forms.ListBox();
            this.clbStrings = new System.Windows.Forms.CheckedListBox();
            this.tbStrToAdd = new System.Windows.Forms.TextBox();
            this.btnAddStr = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStrings
            // 
            this.lbStrings.FormattingEnabled = true;
            this.lbStrings.Location = new System.Drawing.Point(259, 96);
            this.lbStrings.Name = "lbStrings";
            this.lbStrings.Size = new System.Drawing.Size(198, 225);
            this.lbStrings.TabIndex = 0;
            // 
            // clbStrings
            // 
            this.clbStrings.FormattingEnabled = true;
            this.clbStrings.Location = new System.Drawing.Point(490, 96);
            this.clbStrings.Name = "clbStrings";
            this.clbStrings.Size = new System.Drawing.Size(214, 229);
            this.clbStrings.TabIndex = 1;
            // 
            // tbStrToAdd
            // 
            this.tbStrToAdd.Location = new System.Drawing.Point(59, 96);
            this.tbStrToAdd.Name = "tbStrToAdd";
            this.tbStrToAdd.Size = new System.Drawing.Size(100, 20);
            this.tbStrToAdd.TabIndex = 2;
            // 
            // btnAddStr
            // 
            this.btnAddStr.Location = new System.Drawing.Point(72, 142);
            this.btnAddStr.Name = "btnAddStr";
            this.btnAddStr.Size = new System.Drawing.Size(75, 23);
            this.btnAddStr.TabIndex = 3;
            this.btnAddStr.Text = "Add";
            this.btnAddStr.UseVisualStyleBackColor = true;
            this.btnAddStr.Click += new System.EventHandler(this.btnAddStr_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(428, 349);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 4;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.btnAddStr);
            this.Controls.Add(this.tbStrToAdd);
            this.Controls.Add(this.clbStrings);
            this.Controls.Add(this.lbStrings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStrings;
        private System.Windows.Forms.CheckedListBox clbStrings;
        private System.Windows.Forms.TextBox tbStrToAdd;
        private System.Windows.Forms.Button btnAddStr;
        private System.Windows.Forms.Button btnMove;
    }
}

