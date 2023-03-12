namespace Aud1
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnShowMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblDesc.Location = new System.Drawing.Point(303, 45);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(176, 29);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "This is a label.";
            this.lblDesc.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.btnShowMessage.Location = new System.Drawing.Point(293, 219);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(186, 78);
            this.btnShowMessage.TabIndex = 1;
            this.btnShowMessage.Text = "BUTTON";
            this.btnShowMessage.UseVisualStyleBackColor = true;
            this.btnShowMessage.Click += new System.EventHandler(this.btnShowMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowMessage);
            this.Controls.Add(this.lblDesc);
            this.Name = "Form1";
            this.Text = "First App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnShowMessage;
    }
}

