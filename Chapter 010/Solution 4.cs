using System.Text;

namespace Chapter010
{
    public class Solution4
    {
/*
4.Here is an array containing both numbers as well as other arrays, which
in turn contain numbers and arrays:
array = [
 1,
2,
3,
[4, 5, 6],
7,
[8,
[9, 10, 11,
[12, 13, 14]
]
],
[15, 16, 17, 18, 19,
[20, 21, 22,
[23, 24, 25,
[26, 27, 29]
], 30, 31
], 32
], 33
]
Write a recursive function that prints all the numbers (and just numbers).
*/
        public void printArrayRecursively(object[] array)
        {
            foreach (var item in array)
            {
                if (item is int number)
                {
                    Console.WriteLine(number);
                }
                else if (item is object[] subArray)
                {
                    printArrayRecursively(subArray);
                }
            }
        }
    }
}
