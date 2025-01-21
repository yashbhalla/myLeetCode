public class Solution
{
    public int SingleNumber(int[] nums)
    {
        var res = 0;
        foreach (int i in nums)
        {
            res = res ^ i;
        }
        return res;
    }
}


/*
*** MY SOLUTION ***

public class Solution {
    public int SingleNumber(int[] nums) {
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 1; i++)
        {
            if(nums[i] != nums[i+1])
            {
                return nums[i];
            }
            i++;
        }        
        return nums[nums.Length - 1];
    }
}

*/

/*
Example 1:
Input: nums = [2,2,1]
Output: 1

Example 2:
Input: nums = [4,1,2,1,2]
Output: 4

Example 3:
Input: nums = [1]
Output: 1
*/