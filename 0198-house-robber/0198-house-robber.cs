public class Solution {
    public int Rob(int[] nums) {
        int prev1 = 0; // dp[i-1]
        int prev2 = 0; // dp[i-2]
        foreach (int amount in nums)
        {
            int rob = prev2 + amount;   // rob current house
            int skip = prev1;           // skip current house

            int current = Math.Max(rob, skip);

            prev2 = prev1;
            prev1 = current;
        }

        return prev1;
    }
}