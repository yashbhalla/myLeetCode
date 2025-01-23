public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 2)
        {
            return nums.Length;
        }

        Dictionary<int, int> myDict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!myDict.ContainsKey(num))
            {
                myDict.Add(num, 1);
            }
            else
            {
                myDict[num]++;
            }
        }

        int i = 0;

        foreach (var pair in myDict)
        {
            if (pair.Value < 2)
            {
                nums[i] = pair.Key;
                i++;
            }
            else
            {
                nums[i] = pair.Key;
                nums[i + 1] = pair.Key;
                i = i + 2;
            }
        }
        return i;
    }
}

/*
Example 1:
Input: nums = [1,1,1,2,2,3]
Output: 5, nums = [1,1,2,2,3,_]
Explanation: Your function should return k = 5, with the first five elements of nums being 1, 1, 2, 2 and 3 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).

Example 2:
Input: nums = [0,0,1,1,1,1,2,3,3]
Output: 7, nums = [0,0,1,1,2,3,3,_,_]
Explanation: Your function should return k = 7, with the first seven elements of nums being 0, 0, 1, 1, 2, 3 and 3 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).
*/