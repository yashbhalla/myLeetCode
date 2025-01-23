public class Solution
{
    public int MaxProfit(int[] prices)
    {
        /*
        *** TIME LIMIT EXCEEDED ***
        int maxProfit = 0;

        for(int i = 0; i < prices.Length; i++)
        {
            for(int j = i + 1; j < prices.Length; j++)
            {
                if((prices[j] > prices[i]) && ((prices[j] - prices[i]) > maxProfit))
                {
                    maxProfit = prices[j] - prices[i];
                }
            }
        }
        return maxProfit;
        */

        if (prices == null || prices.Length < 2)
        {
            return 0;
        }

        int minPrice = int.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else if (prices[i] - minPrice > maxProfit)
            {
                maxProfit = prices[i] - minPrice;
            }
        }

        return maxProfit;
    }
}

/*
Example 1:
Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.

Example 2:
Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.
*/