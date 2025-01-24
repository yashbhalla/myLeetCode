public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices == null || prices.Length < 2)
        {
            return 0;
        }

        int maxProfit = 0;
        int start = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (start < prices[i])
            {
                maxProfit += prices[i] - start;
            }
            start = prices[i];
        }
        return maxProfit;
    }
}