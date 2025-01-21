public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int left = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] != 0)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
            }
        }
    }
}

/*
Example 1:
Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]

Example 2:
Input: nums = [0]
Output: [0]
*/