
using System.Linq;
using System.Text;


namespace multiplesOfNumbers
{
    internal class fiveLettersOrMore
    {
        public static string SpinWords(string sentence)
        {
            /*
             * Write a function that takes in a string of one or more words, and returns the same string, but with all words that have five or more letters reversed
             */
            string[] words= sentence.Split(' ');
            StringBuilder builder = new StringBuilder();
            foreach (var word in words)
            {
                if (word.Length >= 5)
                {
                    string wordaftter = string.Join("", word.ToCharArray().Reverse());
                    builder.Append($"{wordaftter} ");
                }
                else
                    builder.Append($"{word} ");
            }
            return builder.ToString().TrimEnd();
            /*
             * another solution
            for(int index = 0; index <  words.Length; index++)
            {
                if(words[index].Length >= 5)
                {
                    string word = string.Join("", words[index].ToCharArray().Reverse());
                    words[index] = word;
                }
            }
            return string.Join(" ", words);
            */
        }
    }
}
