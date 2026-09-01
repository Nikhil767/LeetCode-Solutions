public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        var result = new List<int>();
        int m = matrix.Length;
        int n = matrix[0].Length;
        int top = 0, bottom = m - 1;
        int left = 0, right = n - 1;

        while (top <= bottom && left <= right)
        {
            // 1. Traverse left → right
            for (int col = left; col <= right; col++)
                result.Add(matrix[top][col]);
            top++;

            // 2. Traverse top → bottom
            for (int row = top; row <= bottom; row++)
                result.Add(matrix[row][right]);
            right--;

            // 3. Traverse right → left (only if still valid)
            if (top <= bottom)
            {
                for (int col = right; col >= left; col--)
                    result.Add(matrix[bottom][col]);
                bottom--;
            }

            // 4. Traverse bottom → top (only if still valid)
            if (left <= right)
            {
                for (int row = bottom; row >= top; row--)
                    result.Add(matrix[row][left]);
                left++;
            }
        }

        return result;
    }
}