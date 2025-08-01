namespace Chapter008
{
    public class Solution4
    {
/*
4. Write a function that returns the first non-duplicated character in a string.
For example, the string, "minimum" has two characters that only exist
once—the "n" and the "u", so your function should return the "n", since it
occurs first. The function should have an efficiency of O(N).
*/
        public char firstNonDuplicate(string word)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (counts.ContainsKey(word[i]))
                {
                    counts[word[i]]++;
                }
                else
                {
                    counts[word[i]] = 1;
                }
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (counts[word[i]] == 1)
                {
                    return word[i];
                }
            }

            return '\0';
        }
    }
}
