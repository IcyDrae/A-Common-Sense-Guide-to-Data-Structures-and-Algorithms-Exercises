namespace Chapter011
{
    public class Solution1
    {
/*
1. Use recursion to write a function that accepts an array of strings and
returns the total number of characters across all the strings. For example,
if the input array is ["ab", "c", "def", "ghij"], the output should be 10 since there
are 10 characters in total.
*/
        public int totalNumber(string[] strings)
        {
            if (strings.Length == 0)
            {
                return 0;
            }

            string[] rest = strings.Skip(1).ToArray();

            return strings[0].Length + totalNumber(rest);
        }
    }
}
