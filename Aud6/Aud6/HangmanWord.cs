using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aud6
{
    public class HangmanWord
    {
        public string Word { get; set; }
        public HashSet<char> Letters { get; set; }
        public HashSet<char> GuessedLetters { get; set; }
        public int NumTries { get; set; }
        public int Lives { get; set; }

        public HangmanWord(string word, int lives)
        {
            Word = word.ToUpper();
            Letters = new HashSet<char>();
            GuessedLetters = new HashSet<char>();
            NumTries = 0;
            Lives = lives;
            foreach (char c in Word) { Letters.Add(c); }
        }

        public void GuessLetter(char letter)
        {
            letter = char.ToUpper(letter);
            if (Letters.Contains(letter) && !GuessedLetters.Contains(letter))
            {
                Letters.Remove(letter);
                GuessedLetters.Add(letter);
            }
            else
            {
                if (!GuessedLetters.Contains(letter))
                {
                    GuessedLetters.Add(letter);
                    NumTries++;
                }
            }
        }

        public string GetMaskedAlphabetString()
        {
            StringBuilder sb = new StringBuilder();
            for(char c = 'A'; c <= 'Z'; c++)
            {
                if (GuessedLetters.Contains(c))
                    sb.Append(c);
                else sb.Append('_');
                sb.Append(' ');
            }
            return sb.ToString();
        }

        public string GetMaskedWord()
        {
            StringBuilder sb = new StringBuilder();
            foreach(char c in Word)
            {
                if (GuessedLetters.Contains(c))
                    sb.Append(c);
                else sb.Append('_');
                sb.Append(' ');
            }
            return sb.ToString();
        }

        public bool GameOver()
        {
            return (NumTries == Lives) || (Letters.Count == 0);
        }
    }
}
