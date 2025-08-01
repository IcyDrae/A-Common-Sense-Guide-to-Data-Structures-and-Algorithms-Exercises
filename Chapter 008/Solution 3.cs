namespace Chapter008
{
    public class Solution3
    {
/*
3. Write a function that accepts a string that contains all the letters of the
alphabet except one and returns the missing letter. For example, the string,
"the quick brown box jumps over a lazy dog" contains all the letters of the alphabet
except the letter, "f". The function should have a time complexity of O(N).
*/
        public char missingLetter(string sentence)
        {
            HashSet<char> letters = new HashSet<char>();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsLetter(sentence[i]))
                {
                    letters.Add(sentence[i]);
                }
            }

            for (char c = 'a'; c <= 'z'; c++)
            {
                if (!letters.Contains(c))
                {
                    return c;
                }
            }

            return '\0';
        }
    }
}
