public class Solution {
    public int NearestExit(char[][] maze, int[] entrance) {
        int m = maze.Length;
        int n = maze[0].Length;

        var directions = new int[][] {
            new[] {1, 0}, new[] {-1, 0},
            new[] {0, 1}, new[] {0, -1}
        };

        var queue = new Queue<(int r, int c, int dist)>();
        queue.Enqueue((entrance[0], entrance[1], 0));

        maze[entrance[0]][entrance[1]] = '+'; // mark visited

        while (queue.Count > 0)
        {
            var (r, c, dist) = queue.Dequeue();

            foreach (var d in directions)
            {
                int nr = r + d[0];
                int nc = c + d[1];

                // Check bounds and walls
                if (nr < 0 || nr >= m || nc < 0 || nc >= n || maze[nr][nc] == '+')
                    continue;

                // Check if it's an exit (but not the entrance)
                if ((nr == 0 || nr == m - 1 || nc == 0 || nc == n - 1))
                    return dist + 1;

                // Mark visited and continue BFS
                maze[nr][nc] = '+';
                queue.Enqueue((nr, nc, dist + 1));
            }
        }
        return -1;
    }
}