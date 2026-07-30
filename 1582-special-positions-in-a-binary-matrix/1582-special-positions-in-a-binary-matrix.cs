public class Solution {
    public int NumSpecial(int[][] mat) {
        int counter=0;
        int m = mat.Length;
        int n = mat[0].Length;
        int[] rowCount = new int[m];
        int[] columnCount = new int[n];
        for (int i=0; i<mat.Length; i++)
        {
            for (int j=0; j<mat[i].Length; j++)
            {
                if (mat[i][j] == 1)
                {
                    rowCount[i]++;
                    columnCount[j]++;
                }
                    
            }
        }

        for (int i=0; i<mat.Length; i++)
        {
            for (int j=0; j<mat[i].Length; j++)
            {
                if (mat[i][j] == 1 && rowCount[i] == 1 && columnCount[j]==1)                
                    counter++;
            }
        }
        return counter;
    }
}