public class Solution {
    public bool JudgeCircle(string moves) {
        int x = 0, y = 0;
        const char U = 'U';
        const char D = 'D';
        const char L = 'L';
        const char R = 'R';
        foreach (char c in moves)
        {
            switch (c)
            {
                case U: y++; break;
                case D: y--; break;
                case L: x--; break;
                case R: x++; break;
            }
        }
        return x == 0 && y == 0;
    }
}