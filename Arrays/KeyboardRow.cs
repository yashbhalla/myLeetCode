public class Solution
{
    public string[] FindWords(string[] words)
    {
        List<string> result = new List<string>();
        List<char> row1 = new List<char>() { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
        List<char> row2 = new List<char>() { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
        List<char> row3 = new List<char>() { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };


        foreach (var word in words)
        {
            bool flag = true;
            string lowerCaseWord = word.ToLower();

            if (row1.Contains(lowerCaseWord[0]))
            {
                foreach (char letter in lowerCaseWord)
                {
                    if (!row1.Contains(letter))
                    {
                        flag = false;
                        break;
                    }
                }
            }

            else if (row2.Contains(lowerCaseWord[0]))
            {
                foreach (char letter in lowerCaseWord)
                {
                    if (!row2.Contains(letter))
                    {
                        flag = false;
                        break;
                    }
                }
            }

            else if (row3.Contains(lowerCaseWord[0]))
            {
                foreach (char letter in lowerCaseWord)
                {
                    if (!row3.Contains(letter))
                    {
                        flag = false;
                        break;
                    }
                }
            }

            if (flag)
            {
                result.Add(word);
            }
        }
        return result.ToArray();
    }
}

/*
Example 1:
Input: words = ["Hello","Alaska","Dad","Peace"]
Output: ["Alaska","Dad"]
Explanation:
Both "a" and "A" are in the 2nd row of the American keyboard due to case insensitivity.

Example 2:
Input: words = ["omk"]
Output: []

Example 3:
Input: words = ["adsdf","sfd"]
Output: ["adsdf","sfd"]

*/