public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        /*
        *** NOT ALL TEST CASES COVERED ***
        I/P = [9] || O/P = [1, 0] || My O/P = [10]
        ==================================
        digits[digits.Length - 1]++;
        return digits;
        */

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            digits[i]++;
            if (digits[i] != 10)
            {
                return digits;
            }
            digits[i] = 0;
        }

        int[] res = new int[digits.Length + 1];
        res[0] = 1;
        return res;
    }
}

/*
Example 1:
Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Incrementing by one gives 123 + 1 = 124.
Thus, the result should be [1,2,4].

Example 2:
Input: digits = [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.
Incrementing by one gives 4321 + 1 = 4322.
Thus, the result should be [4,3,2,2].

Example 3:
Input: digits = [9]
Output: [1,0]
Explanation: The array represents the integer 9.
Incrementing by one gives 9 + 1 = 10.
Thus, the result should be [1,0].
*/