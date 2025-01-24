public class Solution
{
    public bool CanJump(int[] nums)
    {
        var target = nums.Length - 1;
        for (var i = nums.Length - 2; i >= 0; i--)
        {
            if (nums[i] >= target - i)
            {
                target = i;
            }
        }
        return target == 0;
    }
}