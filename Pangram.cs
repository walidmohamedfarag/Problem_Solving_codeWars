
using System.Text.RegularExpressions;

namespace multiplesOfNumbers
{
    internal class Pangram
    {
        /*
         * A pangram is a sentence that contains every single letter of the alphabet at least once. 
         * For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).
         * Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.
         */
        public static bool IsPangram(string sentence)
        {
            bool isPangram = false;
            const string pangram = "abcdefghijklmnopqrstuvwxyz";
            string sentenceAfterIgnorepPunctuation = Regex.Escape(sentence);
            string sentenceAfterIgnoreNumber = Regex.Replace(sentenceAfterIgnorepPunctuation, @"\d", "");
            sentence = sentenceAfterIgnoreNumber;
            char[] charsPangram = pangram.ToCharArray();
            for (int index = 0; index < pangram.Length; index++)
            {
                if (sentence.Contains(charsPangram[index], StringComparison.InvariantCultureIgnoreCase))
                    isPangram = true;
                else
                    return false;
            }
            return isPangram;
        }
    }
}
