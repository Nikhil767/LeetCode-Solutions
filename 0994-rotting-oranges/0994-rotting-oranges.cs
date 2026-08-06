public class Solution {
    public int OrangesRotting(int[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;

        var queue = new Queue<(int r, int c, int time)>();
        int fresh = 0;

        // Step 1: collect initial rotten oranges
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 2)
                    queue.Enqueue((i, j, 0));
                else if (grid[i][j] == 1)
                    fresh++;
            }
        }

        if (fresh == 0)
            return 0;

        int minutes = 0;
        int[][] dirs = {
            new[] {1, 0}, new[] {-1, 0},
            new[] {0, 1}, new[] {0, -1}
        };

        // Step 2: BFS rotting
        while (queue.Count > 0)
        {
            var (r, c, time) = queue.Dequeue();
            minutes = Math.Max(minutes, time);

            foreach (var d in dirs)
            {
                int nr = r + d[0];
                int nc = c + d[1];

                if (nr < 0 || nr >= m || nc < 0 || nc >= n)
                    continue;

                if (grid[nr][nc] == 1)
                {
                    grid[nr][nc] = 2; // rot it
                    fresh--;
                    queue.Enqueue((nr, nc, time + 1));
                }
            }
        }
        return fresh == 0 ? minutes : -1;
    }
}