using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aud6
{
    public partial class HangmanForm : Form
    {
        public HangmanWord Hangman { get; set; }
        public List<string> Words = new List<string>() { "Macedonia", "Australia", "Canada", "Sweden", "Finland"};
        Random rand = new Random();
        public int TimeLeft { get; set; } = 120;
        public HangmanForm()
        {
            InitializeComponent();
            Hangman = new HangmanWord(Words[rand.Next(Words.Count)], 5);
            lblWord.Text = Hangman.GetMaskedWord();
            lblGuessed.Text = Hangman.GetMaskedAlphabetString();
            timer1.Start();
            pbTime.Value = 120;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (tbGuess.Text.Length == 1 && char.IsLetter(tbGuess.Text[0]))
            {
                Hangman.GuessLetter(tbGuess.Text[0]);
                lblWord.Text = Hangman.GetMaskedWord();
                lblGuessed.Text = Hangman.GetMaskedAlphabetString();
                tbGuess.Clear();
                if (Hangman.GameOver())
                {
                    this.Close();
                }
                pbGuesses.Value = (int) (100.0 * Hangman.NumTries / Hangman.Lives);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLeft--;
            lblTimer.Text = $"{TimeLeft / 60:D2}:{TimeLeft % 60:D2}";
            if (TimeLeft == 0)
                this.Close();
            pbTime.Value--;
        }
    }
}
