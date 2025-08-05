namespace Chapter011
{
    public class Solution2
    {
/*
2. Use recursion to write a function that accepts an array of numbers and
returns a new array containing just the even numbers.
*/
        public int[] evenNumbers(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return new int[0];
            }

            int[] rest = evenNumbers(numbers.Skip(1).ToArray());

            if (numbers[0] % 2 == 0)
            {
                return (new int[] { numbers[0] }).Concat(rest).ToArray();
            }
            else
            {
                return rest;
            }

        }
    }
}
