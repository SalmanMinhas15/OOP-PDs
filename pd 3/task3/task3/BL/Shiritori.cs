using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
    internal class Shiritori
    {
        public string previousWord = "salman";
        public bool gameOver = false;
        public string[] words = new string[10];
        public int i = 0;

       
        public void play()
        {
            while (!gameOver)
            {
                DisplayPreviousWord();
                string newWord = GetNextWord();
                if (!IsValidWord(newWord) )
                {
                    gameOver = true;
                }
                else
                {
                    words[i++] = newWord;
                    previousWord = newWord;
                }
            }
        }

        public void DisplayPreviousWord()
        {
            Console.WriteLine("\n\nThe previous word is: " + previousWord);
        }

        public string GetNextWord()
        {
            Console.Write("Enter the next word: ");
            return Console.ReadLine();
        }

        public bool IsValidWord(string word)
        {
            if (word.Length == 0 || word[0] != previousWord[previousWord.Length - 1])
                return false;
            return true;
        }
    }
}
