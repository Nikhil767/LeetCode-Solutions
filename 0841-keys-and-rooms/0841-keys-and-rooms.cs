public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
       int n = rooms.Count;
        bool[] visited = new bool[n];

        DFS(0, rooms, visited);

        foreach (bool v in visited)
        {
            if (!v) return false;
        }
        return true;
    }

    private void DFS(int room, IList<IList<int>> rooms, bool[] visited)
    {
        visited[room] = true;
        foreach (int key in rooms[room])
        {
            if (!visited[key])
            {
                DFS(key, rooms, visited);
            }
        }
    }
}