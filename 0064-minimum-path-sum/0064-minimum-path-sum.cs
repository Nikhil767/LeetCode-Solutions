public class Solution {
    public int MinPathSum(int[][] grid) {
        int rows = grid.Length;
    int cols = grid[0].Length;

    int[,] dp = new int[rows, cols];

    dp[0, 0] = grid[0][0];

    for (int c = 1; c < cols; c++)
        dp[0, c] = dp[0, c - 1] + grid[0][c];

    for (int r = 1; r < rows; r++)
        dp[r, 0] = dp[r - 1, 0] + grid[r][0];

    for (int r = 1; r < rows; r++)
    {
        for (int c = 1; c < cols; c++)
        {
            dp[r, c] = Math.Min(dp[r - 1, c], dp[r, c - 1]) + grid[r][c];
        }
    }

    return dp[rows - 1, cols - 1];
    }
}