public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        Array.Sort(strs);
        int i = 0;
        string firstWord = strs[0];
        string lastWord = strs[strs.Length - 1];
        StringBuilder result = new StringBuilder();

        while (i < firstWord.Length && i < lastWord.Length && firstWord[i] == lastWord[i])
        {
            result.Append(firstWord[i]);
            i++;
        }
        return result.ToString();
    }
}

/*
Example 1:
Input: strs = ["flower","flow","flight"]
Output: "fl"

Example 2:
Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
*/