public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        if (triangle == null || triangle.Count == 0)
        return 0;

    int rows = triangle.Count;

    // Copy last row
    int[] dp = new int[triangle[rows - 1].Count];

    for (int i = 0; i < triangle[rows - 1].Count; i++)
    {
        dp[i] = triangle[rows - 1][i];
    }

    // Process from second-last row to top
    for (int row = rows - 2; row >= 0; row--)
    {
        for (int col = 0; col <= row; col++)
        {
            dp[col] = triangle[row][col] +
                      Math.Min(dp[col], dp[col + 1]);
        }
    }

    return dp[0];
    }
}