public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        // Base cases
        if (cost == null || cost.Length == 0) return 0;
        if (cost.Length == 1) return cost[0];

        // prev2 represents min cost to reach step (i - 2)
        // prev1 represents min cost to reach step (i - 1)
        int prev2 = 0; 
        int prev1 = 0; 

        // Loop to reach top (index cost.Length)
        for (int i = 2; i <= cost.Length; i++)
        {
            // Compute min cost to reach step i
            int current = Math.Min(prev1 + cost[i - 1], prev2 + cost[i - 2]);

            // Shift variables forward for next iteration
            prev2 = prev1;
            prev1 = current;
        }

        return prev1; // prev1 holds the min cost to reach top
    }
}