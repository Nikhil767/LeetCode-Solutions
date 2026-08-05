public class Solution {
    public int MinReorder(int n, int[][] connections) {
        var graph = new List<(int to, int cost)>[n];
        for (int i = 0; i < n; i++)
            graph[i] = new List<(int, int)>();

        // Build adjacency list
        foreach (var c in connections)
        {
            int a = c[0], b = c[1];

            // Original direction: a -> b (cost = 1 means needs reversal)
            graph[a].Add((b, 1));

            // Reverse direction: b -> a (cost = 0 means correct direction)
            graph[b].Add((a, 0));
        }

        int result = 0;
        var visited = new bool[n];
        var queue = new Queue<int>();
        queue.Enqueue(0);
        visited[0] = true;

        while (queue.Count > 0)
        {
            int node = queue.Dequeue();
            foreach (var (to, cost) in graph[node])
            {
                if (!visited[to])
                {
                    visited[to] = true;
                    result += cost;   // cost=1 → edge must be reversed
                    queue.Enqueue(to);
                }
            }
        }
        return result;
    }
}