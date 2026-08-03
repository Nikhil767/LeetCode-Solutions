public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        int n = isConnected.Length;
        bool[] visited = new bool[n];
        int provinces = 0;

        for (int i = 0; i < n; i++)
        {
            if (!visited[i])
            {
                DFS(i, isConnected, visited);
                provinces++;
            }
        }
        return provinces;
    }

    private void DFS(int city, int[][] isConnected, bool[] visited)
    {
        visited[city] = true;
        for (int j = 0; j < isConnected.Length; j++)
        {
            if (isConnected[city][j] == 1 && !visited[j])
            {
                DFS(j, isConnected, visited);
            }
        }
    }
}