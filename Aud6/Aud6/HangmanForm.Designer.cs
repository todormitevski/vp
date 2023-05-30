namespace Aud6
{
    partial class HangmanForm
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
            this.components = new System.ComponentModel.Container();
            this.pbGuesses = new System.Windows.Forms.ProgressBar();
            this.pbTime = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblWord = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblGuessed = new System.Windows.Forms.Label();
            this.tbGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pbGuesses
            // 
            this.pbGuesses.Location = new System.Drawing.Point(12, 219);
            this.pbGuesses.Name = "pbGuesses";
            this.pbGuesses.Size = new System.Drawing.Size(636, 23);
            this.pbGuesses.TabIndex = 0;
            // 
            // pbTime
            // 
            this.pbTime.Location = new System.Drawing.Point(12, 248);
            this.pbTime.Maximum = 120;
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(636, 23);
            this.pbTime.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(13, 19);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(112, 31);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "lblWord";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(612, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(34, 13);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "02:00";
            // 
            // lblGuessed
            // 
            this.lblGuessed.AutoSize = true;
            this.lblGuessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessed.Location = new System.Drawing.Point(13, 140);
            this.lblGuessed.Name = "lblGuessed";
            this.lblGuessed.Size = new System.Drawing.Size(160, 31);
            this.lblGuessed.TabIndex = 1;
            this.lblGuessed.Text = "lblGuessed";
            // 
            // tbGuess
            // 
            this.tbGuess.Location = new System.Drawing.Point(20, 90);
            this.tbGuess.MaxLength = 1;
            this.tbGuess.Name = "tbGuess";
            this.tbGuess.Size = new System.Drawing.Size(33, 20);
            this.tbGuess.TabIndex = 2;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(78, 90);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 20);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // HangmanForm
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 299);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.tbGuess);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblGuessed);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.pbTime);
            this.Controls.Add(this.pbGuesses);
            this.Name = "HangmanForm";
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbGuesses;
        private System.Windows.Forms.ProgressBar pbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblGuessed;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Button btnGuess;
    }
}

