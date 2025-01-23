public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> num = new Dictionary<char, int>(){
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
        };
        int result = 0;
        bool flag = true;

        for (int i = 0; i < s.Length - 1; i++)
        {
            flag = true;
            if (s[i] == 'I' && s[i + 1] == 'V')
            {
                flag = false;
                result = result + 4;
                i++;
            }
            else if (s[i] == 'I' && s[i + 1] == 'X')
            {
                flag = false;
                result = result + 9;
                i++;
            }
            else if (s[i] == 'X' && s[i + 1] == 'L')
            {
                flag = false;
                result = result + 40;
                i++;
            }
            else if (s[i] == 'X' && s[i + 1] == 'C')
            {
                flag = false;
                result = result + 90;
                i++;
            }
            else if (s[i] == 'C' && s[i + 1] == 'D')
            {
                flag = false;
                result = result + 400;
                i++;
            }
            else if (s[i] == 'C' && s[i + 1] == 'M')
            {
                flag = false;
                result = result + 900;
                i++;
            }
            else
            {
                result = result + num[s[i]];
            }

            if (i == s.Length - 1 && flag == true || (i + 1) == s.Length - 1 && flag == false)
            {
                flag = true;
            }
        }
        if (flag)
        {
            result = result + num[s[s.Length - 1]];
        }
        return result;
    }
}

/*
Example 1:
Input: s = "III"
Output: 3
Explanation: III = 3.

Example 2:
Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.

Example 3:
Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
*/