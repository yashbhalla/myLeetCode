public class Solution
{
    public int MajorityElement(int[] nums)
    {
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

        int temp = 0;
        int res = 0;

        foreach (var pair in myDict)
        {
            if (pair.Value > temp)
            {
                temp = pair.Value;
                res = pair.Key;
            }
        }

        return res;
    }
}

/*
Given an array nums of size n, return the majority element. The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

Example 1:
Input: nums = [3,2,3]
Output: 3

Example 2:
Input: nums = [2,2,1,1,1,2,2]
Output: 2
*/