public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;
        // 1. Transpose the matrix (swap matrix[i][j] with matrix[j][i])
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
        // 2. Reverse each row (to complete 90° clockwise rotation)
        for (int i = 0; i < n; i++)
        {
            int left = 0;
            int right = n - 1;
            while (left < right)
            {
                int temp = matrix[i][left];
                matrix[i][left] = matrix[i][right];
                matrix[i][right] = temp;
                left++;
                right--;
            }
        }
    }
}