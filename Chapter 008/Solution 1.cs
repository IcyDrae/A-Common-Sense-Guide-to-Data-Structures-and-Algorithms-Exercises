using System.Diagnostics.Metrics;

namespace Chapter008
{
    public class Solution1
    {
/*
1. Write a function that returns the intersection of two arrays. The intersec-
tion is a third array that contains all values contained within the first two
arrays. For example, the intersection of [1, 2, 3, 4, 5] and [0, 2, 4, 6, 8] is [2, 4].
Your function should have a complexity of O(N). (If your programming
language has a built-in way of doing this, don’t use it. The idea is to build
the algorithm yourself.)
*/
        public int[] intersection(int[] array1, int[] array2)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> result = new List<int>();

            for (int i = 0; i < array1.Length; i++)
            {
                seen.Add(array1[i]);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (seen.Contains(array2[i]))
                {
                    result.Add(array2[i]);
                    seen.Remove(array2[i]);
                }
            }

            return result.ToArray();
        }
    }
}
