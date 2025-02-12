public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) { return 0; }

        int len = 0;
        int[] resArr = new int[nums.Length];
        bool flag = true;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < len; j++)
            {
                if (resArr[j].Equals(nums[i]))
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                resArr[len] = nums[i];
                nums[len] = nums[i];
                len++;
            }
            flag = true;
        }

        return len;
    }
}


/*
Example 1:
Input: nums = [1,1,2]
Output: 2, nums = [1,2,_]
Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).

Example 2:
Input: nums = [0,0,1,1,1,2,2,3,3,4]
Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).
*/