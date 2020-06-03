using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercises
{
    public class FiveLetterWords
    {
        public static string GetFiveLetterWords(List<string> words)
        {
            StringBuilder fiveLetterWords = new StringBuilder();
            foreach (string word in words)
            {
                if (word.Length == 5)
                {
                    fiveLetterWords.Append(word + "\n");
                }
            }
            return fiveLetterWords.ToString();
        }
    }
}
