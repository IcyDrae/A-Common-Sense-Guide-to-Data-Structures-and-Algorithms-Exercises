namespace Exercises
{
    public class Chapter004
    {
/*
4.The following function finds the greatest single number within an array,
but has an efficiency of O(N²). Rewrite the function so that it becomes a
speedy O(N):
def greatestNumber(array):
    for i in array:
        # Assume for now that i is the greatest:
        isIValTheGreatest = True
            for j in array:
            # If we find another value that is greater than i,
            # i is not the greatest:
            if j > i:
            isIValTheGreatest = False
            # If, by the time we checked all the other numbers, i
            # is still the greatest, it means that i is the greatest number:
        if isIValTheGreatest:
            return i
*/
        public int GreatestNumber(int[] nums)
        {
            int Greatest = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                // Keep track of the greatest number and compare each number
                // with it, updating it as we go through the array.
                if (nums[i] > Greatest)
                {
                    Greatest = nums[i];
                }
            }

            return Greatest;
        }
    }
}
