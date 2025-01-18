public class Solution
{
    public int MaxAdjacentDistance(int[] nums)
    {
        int diff = Math.Abs(nums[0] - nums[nums.Length - 1]);

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (Math.Abs(nums[i] - nums[i + 1]) > diff)
            {
                diff = Math.Abs(nums[i] - nums[i + 1]);
            }
        }
        return diff;
    }
}