public class Solution {
    public void GameOfLife(int[][] board) {
        int rows = board.Length;
        int cols = board[0].Length;

        int[] directions = { -1, 0, 1 };

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                int liveNeighbors = 0;

                foreach (int dr in directions)
                {
                    foreach (int dc in directions)
                    {
                        if (dr == 0 && dc == 0)
                            continue;

                        int nr = r + dr;
                        int nc = c + dc;

                        if (nr < 0 || nr >= rows || nc < 0 || nc >= cols)
                            continue;

                        if (Math.Abs(board[nr][nc]) == 1)
                            liveNeighbors++;
                    }
                }

                if (board[r][c] == 1)
                {
                    if (liveNeighbors < 2 || liveNeighbors > 3)
                        board[r][c] = -1; // live -> dead
                }
                else
                {
                    if (liveNeighbors == 3)
                        board[r][c] = 2; // dead -> live
                }
            }
        }

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (board[r][c] > 0)
                    board[r][c] = 1;
                else
                    board[r][c] = 0;
            }
        }
    }
}