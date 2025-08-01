using System.Text;

namespace Chapter009
{
    public class Solution4
    {
/*
4. Write a function that uses a stack to reverse a string. (For example, "abcde"
would become "edcba".) You can work with our earlier implementation of
the Stack class.
*/
        public string reverseString(string word)
        {
            Stack<char> reverseOrder = new Stack<char>();

            for (int i = 0; i < word.Length; i++)
            {
                reverseOrder.Push(word[i]);
            }

            StringBuilder reverse = new StringBuilder();

            while (reverseOrder.Count > 0)
            {
                reverse.Append(
                    reverseOrder.Pop()
                );
            }

            return reverse.ToString();
        }
    }
}
