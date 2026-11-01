public class Solution {
    public int MaximalSquare(char[][] matrix) {
        int rows = matrix.Length;
    int cols = matrix[0].Length;

    int[,] dp = new int[rows + 1, cols + 1];
    int maxSide = 0;

    for (int r = 1; r <= rows; r++)
    {
        for (int c = 1; c <= cols; c++)
        {
            if (matrix[r - 1][c - 1] == '1')
            {
                dp[r, c] = Math.Min(
                    Math.Min(dp[r - 1, c], dp[r, c - 1]),
                    dp[r - 1, c - 1]
                ) + 1;

                maxSide = Math.Max(maxSide, dp[r, c]);
            }
        }
    }

    return maxSide * maxSide;
    }
}