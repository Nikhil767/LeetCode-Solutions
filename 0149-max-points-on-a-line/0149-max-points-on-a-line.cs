public class Solution {
    public int MaxPoints(int[][] points) {
        if (points.Length <= 2)
            return points.Length;

        int result = 0;

        for (int i = 0; i < points.Length; i++)
        {
            Dictionary<(int, int), int> slopes = new();
            int maxOnLine = 0;

            for (int j = i + 1; j < points.Length; j++)
            {
                int dx = points[j][0] - points[i][0];
                int dy = points[j][1] - points[i][1];

                int gcd = GCD(dx, dy);
                dx /= gcd;
                dy /= gcd;

                if (dx < 0)
                {
                    dx = -dx;
                    dy = -dy;
                }
                else if (dx == 0)
                {
                    dy = 1;
                }
                else if (dy == 0)
                {
                    dx = 1;
                }

                var slope = (dy, dx);

                slopes[slope] = slopes.GetValueOrDefault(slope, 0) + 1;
                maxOnLine = Math.Max(maxOnLine, slopes[slope]);
            }

            result = Math.Max(result, maxOnLine + 1);
        }

        return result;

        int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a == 0 ? 1 : a;
        }
    }
}