public class Solution {
    public bool PredictTheWinner(int[] nums) {
        int n = nums.Length;
        int[,] memo = new int[n, n];
        return GetMaxScoreDiff(nums, 0, nums.Length - 1, memo) >= 0;
    }

    public int GetMaxScoreDiff(int[] nums, int i, int j, int[,] memo)
    {
        // Base case: only one element left
        if (i == j) return nums[i];

        // Return memoized result if already computed
        if (memo[i, j] != 0) return memo[i, j];

        // Option 1: Pick left element nums[i]
        int takeLeft = nums[i] - GetMaxScoreDiff(nums, i + 1, j, memo);

        // Option 2: Pick right element nums[j]
        int takeRight = nums[j] - GetMaxScoreDiff(nums, i, j - 1, memo);

        // Store and return the optimal score difference
        memo[i, j] = Math.Max(takeLeft, takeRight);
        return memo[i, j];
    }
}