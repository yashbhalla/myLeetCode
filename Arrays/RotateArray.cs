public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        /*
        *** Time Limit Exceeded ***
        while(k != 0)
        {
            int lastNum = nums[nums.Length - 1];
            for(int i = nums.Length - 1; i > 0; i--)
            {
                nums[i] = nums[i - 1];
            }
            nums[0] = lastNum;
            k--;
        }        
        */

        int n = nums.Length;

        // Handle the case where k is greater than n
        k = k % n;

        // Reverse the entire array
        Reverse(nums, 0, n - 1);

        // Reverse the first k elements
        Reverse(nums, 0, k - 1);

        // Reverse the remaining elements
        Reverse(nums, k, n - 1);
    }

    private void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}