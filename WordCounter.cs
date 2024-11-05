using System;

namespace WordCount
{
    public class WordCounter
    {
        public int Count(string text, string word)
        {
            int amount = 0;
            int start = text.ToLower().IndexOf(word.ToLower());

            while (start != -1)
            {
                amount++;
                start = text.ToLower().IndexOf(word.ToLower(), start + 1);
            }

            return amount;
        }
    }
}
