public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        int n = prices.Length;
        int hold = -prices[0];   // If we buy on day 0
        int cash = 0;            // No stock initially

        for (int i = 1; i < n; i++)
        {
            hold = Math.Max(hold, cash - prices[i]);
            cash = Math.Max(cash, hold + prices[i] - fee);
        }
        return cash;
    }
}