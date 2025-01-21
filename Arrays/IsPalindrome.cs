public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x == 0)
        {
            return true;
        }
        else if (x < 0)
        {
            return false;
        }
        else if (x % 10 == 0)
        {
            return false;
        }
        else
        {
            int compare = 0;
            int temp = x;

            while (x != 0)
            {
                compare = compare * 10 + x % 10;
                x /= 10;
            }

            if (compare.Equals(temp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}

/*

Example 1:
Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

Example 2:
Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

Example 3:
Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.

*/