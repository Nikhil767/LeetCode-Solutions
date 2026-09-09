public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        int x0 = coordinates[0][0];
        int y0 = coordinates[0][1];

        int x1 = coordinates[1][0];
        int y1 = coordinates[1][1];

        // Base slope components
        int dx = x1 - x0;
        int dy = y1 - y0;

        for (int i = 2; i < coordinates.Length; i++)
        {
            int x = coordinates[i][0];
            int y = coordinates[i][1];

            // Compare slopes using cross multiplication:
            // (y - y0) / (x - x0) == dy / dx
            if ((y - y0) * dx != (x - x0) * dy)
                return false;
        }

        return true;
    }
}