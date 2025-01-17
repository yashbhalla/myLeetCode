public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i].Equals(target) || target < nums[i])
            {
                return i;
            }
        }
        return nums.Length;
    }
}

/*
Example 1:
Input: nums = [1,3,5,6], target = 5
Output: 2

Example 2:
Input: nums = [1,3,5,6], target = 2
Output: 1

Example 3:
Input: nums = [1,3,5,6], target = 7
Output: 4

*/