namespace Chapter013
{
    public class Solution1
    {
/*
1. Given an array of positive numbers, write a function that returns the
greatest product of any three numbers. The approach of using three
nested loops would clock in at O(N³), which is very slow. Use sorting to
implement the function in a way that it computes at O(N log N) speed.
(There are even faster implementations, but we’re focusing on using
sorting as a technique to make code faster.)
*/
        public int greatestProduct(int[] numbers)
        {
            Array.Sort(numbers);
            int length = numbers.Length;

            return numbers[length - 1] * numbers[length - 2] * numbers[length - 3];
        }
    }
}
