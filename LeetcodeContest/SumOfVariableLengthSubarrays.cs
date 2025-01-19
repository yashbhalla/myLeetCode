public class Solution {
    public int SubarraySum(int[] nums) {
        int sum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            int start = Math.Max(0, i - nums[i]);
            sum = sum + nums[i];
            for(int j = start; j < i; j++)
            {
                sum = sum + nums[j];
            }
        }
        return sum;
    }
}
