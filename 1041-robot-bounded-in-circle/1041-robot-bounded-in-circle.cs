public class Solution {
    public bool IsRobotBounded(string instructions) {
        int x = 0, y = 0;
        int dir = 0; // 0 = North, 1 = East, 2 = South, 3 = West

        foreach (char c in instructions)
        {
            if (c == 'G')
            {
                if (dir == 0) y++;
                else if (dir == 1) x++;
                else if (dir == 2) y--;
                else x--;
            }
            else if (c == 'L')
            {
                dir = (dir + 3) % 4; // turn left
            }
            else // 'R'
            {
                dir = (dir + 1) % 4; // turn right
            }
        }

        // Bounded if:
        // 1. Back at origin, OR
        // 2. Not facing north
        return (x == 0 && y == 0) || dir != 0;
    }
}