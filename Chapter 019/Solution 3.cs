namespace Chapter019
{
    public class Solution3
    {
/*
3. Create a new function to reverse an array that takes up just O(1) extra space.
*/
        public void reverse(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left < right)
            {
                // Swap array[left] and array[right]
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;

                left++;
                right--;
            }
        }
    }
}
