namespace Grind75;

public static class StockSlidingWindow
{
    public static int MaxProfitSlidingApproach(int[] prices)
    {
        // [7,1,5,3,6,4]
        int maxProfit = 0;
        int l = 0;
        int r = 1;

        while (r < prices.Length)
        {
            if (prices[l] < prices[r])
            {
                var profit = prices[r] - prices[l];
                maxProfit = Math.Max(maxProfit, profit);
            }
            else
            {
                l = r;
            }
            r++;
        }

        return maxProfit;
    }

    public static int MaxProfitGreedyApproach(int[] prices)
    {
        int min = int.MaxValue;
        int result = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            min = Math.Min(min, prices[i]);
            result = Math.Max(result, prices[i] - min);
        }

        return result;
    }
}
