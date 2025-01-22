public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, List<int>> myDict = new Dictionary<int, List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!myDict.ContainsKey(nums[i]))
            {
                myDict[nums[i]] = new List<int>();
            }

            myDict[nums[i]].Add(i);
        }

        foreach (var pair in myDict)
        {
            List<int> indices = pair.Value;
            for (int j = 1; j < indices.Count; j++)
            {
                if (Math.Abs(indices[j] - indices[j - 1]) <= k)
                {
                    return true;
                }
            }
        }
        return false;
    }
}

/*
Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

Example 1:
Input: nums = [1,2,3,1], k = 3
Output: true

Example 2:
Input: nums = [1,0,1,1], k = 1
Output: true

Example 3:
Input: nums = [1,2,3,1,2,3], k = 2
Output: false
*/