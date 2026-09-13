public class Solution {
    public string Tictactoe(int[][] moves) {
        int n = 3;

        // Score arrays for A and B
        int[] rows = new int[n];
        int[] cols = new int[n];
        int diag = 0, antiDiag = 0;

        // A = +1, B = -1
        int player = 1;

        foreach (var move in moves)
        {
            int r = move[0];
            int c = move[1];

            rows[r] += player;
            cols[c] += player;

            if (r == c)
                diag += player;

            if (r + c == n - 1)
                antiDiag += player;

            // Check win condition
            if (Math.Abs(rows[r]) == n ||
                Math.Abs(cols[c]) == n ||
                Math.Abs(diag) == n ||
                Math.Abs(antiDiag) == n)
            {
                return player == 1 ? "A" : "B";
            }
            // Switch player
            player *= -1;
        }
        // If all moves played
        return moves.Length == n * n ? "Draw" : "Pending";
    }
}