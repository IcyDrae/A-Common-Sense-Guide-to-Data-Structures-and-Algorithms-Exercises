namespace Chapter011
{
    public class Solution5
    {
/*
5. This problem is known as the “Unique Paths” problem: Let’s say you have
a grid of rows and columns. Write a function that accepts a number of rows
and a number of columns, and calculates the number of possible “shortest”
paths from the upper-leftmost square to the lower-rightmost square.
For example, here’s what the grid looks like with three rows and seven
columns. You want to get from the “S” (Start) to the “F” (Finish).
*/
        public int uniquePaths(int rows, int columns)
        {
            if (rows == 1 || columns == 1)
            {
                return 1;
            }

            return
                uniquePaths(rows - 1, columns) +
                uniquePaths(rows, columns - 1);
        }
    }
}
