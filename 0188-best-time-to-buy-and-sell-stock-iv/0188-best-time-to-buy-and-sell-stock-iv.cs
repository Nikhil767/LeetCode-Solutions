public class Solution {
    public int MaxProfit(int k, int[] prices) {
        int n = prices.Length;
        if (n == 0 || k == 0) return 0;

        if (k >= n / 2)
        {
            int profit = 0;
            for (int i = 1; i < n; i++)
            {
                if (prices[i] > prices[i - 1])
                    profit += prices[i] - prices[i - 1];
            }
            return profit;
        }

        int[] buy = new int[k + 1];
        int[] sell = new int[k + 1];

        for (int i = 0; i <= k; i++)
            buy[i] = int.MinValue;

        foreach (int price in prices)
        {
            for (int t = 1; t <= k; t++)
            {
                buy[t] = Math.Max(buy[t], sell[t - 1] - price);
                sell[t] = Math.Max(sell[t], buy[t] + price);
            }
        }

        return sell[k];
    }
}