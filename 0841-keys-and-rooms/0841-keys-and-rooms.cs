public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
       int n = rooms.Count;
        bool[] visited = new bool[n];

        void DFS(int room) {
            visited[room] = true;
            foreach (int key in rooms[room]) {
                if (!visited[key]) {
                    DFS(key);
                }
            }
        }

        DFS(0);

        // Check if all rooms were visited
        foreach (bool v in visited) {
            if (!v) return false;
        }
        return true;
    }
}