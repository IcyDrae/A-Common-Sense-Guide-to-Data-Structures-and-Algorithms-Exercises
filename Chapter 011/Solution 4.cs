namespace Chapter011
{
    public class Solution4
    {
/*
4. Use recursion to write a function that accepts a string and returns the
first index that contains the character “x.” For example, the string,
"abcdefghijklmnopqrstuvwxyz" has an “x” at index 23. To keep things simple,
assume the string definitely has at least one “x.”
*/
        public int firstIndexOfX(string letters, int index = 0)
        {
            if (letters[0] == 'x')
            {
                return index;
            }
            else
            {
                return firstIndexOfX(
                    new string(letters.Skip(1).ToArray()),
                    index + 1
                );
            }
        }
    }
}
