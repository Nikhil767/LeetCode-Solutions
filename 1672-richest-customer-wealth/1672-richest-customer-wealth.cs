public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int maxWealth = 0;
        foreach (var customer in accounts)
        {
            int wealth = 0;
            foreach (var money in customer)
            {
                wealth += money;
            }

            if (wealth > maxWealth)
                maxWealth = wealth;
        }

        return maxWealth;
    }
}