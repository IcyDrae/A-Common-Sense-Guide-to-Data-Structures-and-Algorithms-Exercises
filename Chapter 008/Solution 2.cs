namespace Chapter008
{
    public class Solution2
    {
/*
2. Write a function that accepts an array of strings and returns the first
duplicate value it finds. For example, if the array is ["a", "b", "c", "d", "c", "e",
"f"], the function should return "c", since it’s duplicated within the array.
(You can assume that there’s one pair of duplicates within the array.)
Make sure the function has an efficiency of O(N).
*/
        public string firstDuplicate(string[] array)
        {
            HashSet<string> seen = new HashSet<string>();

            for (int i = 0; i < array.Length; i++)
            {
                if (seen.Contains(array[i]))
                {
                    return array[i];
                }
                else
                {
                    seen.Add(array[i]);
                }
            }

            return "";
        }
    }
}
