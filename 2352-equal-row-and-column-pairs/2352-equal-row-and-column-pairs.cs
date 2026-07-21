public class Solution {
    public int EqualPairs(int[][] grid) {
        if(grid is null || grid.Length < 1) return 0;
        int count = 0;
        int n = grid.Length;
        Dictionary<string, int> freq = new (n*n);        
        // iterate through rows
        for (int row=0; row<n; row++)
        {
            var rowKey = string.Join(',',grid[row]);
            if (!freq.ContainsKey(rowKey))
                freq.Add(rowKey,1);
            else
                freq[rowKey]++;
        }

        // iterate through columns
        int[] colElements = new int[n];
        for (int column=0; column<n; column++)
        {            
            for (int row=0; row<n; row++)            
                colElements[row] = grid[row][column];            
            var colKey = string.Join(',',colElements);
            // If colKey is in dictionary, add its frequency count!
            if (freq.TryGetValue(colKey, out int rowCount))            
                count += rowCount;            
        }
        return count;
    }
}