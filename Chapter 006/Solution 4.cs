namespace Exercises
{
    public class Chapter006
    {
/*
4. The following function returns whether or not a capital “X” is present
within a string.
function containsX(string) {
foundX = false;
for(let i = 0; i < string.length; i++) {
if (string[i] === "X") {
foundX = true;
}
}
return foundX;
}
What is this function’s time complexity in terms of Big O Notation?
Then, modify the code to improve the algorithm’s efficiency for best- and
average-case scenarios.

Answer: This function's time complexity is O(N) because we check each
character of the string for an capital X.
*/
        public bool containsX(string letters)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == 'X')
                {
/*
In the best case (when X is right in the beginning), we end early by returning
true. This yields us O(1).
In the average case (when X is in the middle), we also end early. This
yields better than O(N) but not quite O(N) because we don't iterate
through the whole string.
"return true" is the key here.
*/
                    return true;
                }
            }

            return false;
        }
    }
}
