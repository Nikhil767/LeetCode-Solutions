public class Solution {
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
        var graph = new Dictionary<string, List<(string neighbor, double weight)>>();

        // Build graph
        for (int i = 0; i < equations.Count; i++)
        {
            string a = equations[i][0];
            string b = equations[i][1];
            double val = values[i];

            if (!graph.ContainsKey(a)) graph[a] = new List<(string, double)>();
            if (!graph.ContainsKey(b)) graph[b] = new List<(string, double)>();

            graph[a].Add((b, val));       // a / b = val
            graph[b].Add((a, 1.0 / val)); // b / a = 1/val
        }

        var result = new List<double>();

        // Process queries
        foreach (var q in queries)
        {
            string start = q[0];
            string end = q[1];

            // If either variable doesn't exist
            if (!graph.ContainsKey(start) || !graph.ContainsKey(end))
            {
                result.Add(-1.0);
                continue;
            }

            // BFS/DFS to find ratio
            var visited = new HashSet<string>();
            var queue = new Queue<(string node, double product)>();
            queue.Enqueue((start, 1.0));
            visited.Add(start);

            double answer = -1.0;

            while (queue.Count > 0)
            {
                var (node, product) = queue.Dequeue();

                if (node == end)
                {
                    answer = product;
                    break;
                }

                foreach (var (next, weight) in graph[node])
                {
                    if (!visited.Contains(next))
                    {
                        visited.Add(next);
                        queue.Enqueue((next, product * weight));
                    }
                }
            }
            result.Add(answer);
        }
        return result.ToArray();
    }
}