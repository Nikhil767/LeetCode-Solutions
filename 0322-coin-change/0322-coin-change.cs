public class Solution {
    public int CoinChange(int[] coins, int amount) {
        
        // dp[i] = minimum coins needed to make amount i
        int[] dp = new int[amount + 1];

        // Initialize with an impossible large value
        Array.Fill(dp, amount + 1);

        dp[0] = 0; // 0 coins needed to make amount 0

        for (int i = 1; i <= amount; i++)
        {
            foreach (int coin in coins)
            {
                if (coin <= i)
                {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }

        return dp[amount] > amount ? -1 : dp[amount];
    }
}