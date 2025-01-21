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

/*
Example 1:
Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]

Example 2:
Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]
*/