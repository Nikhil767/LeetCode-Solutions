public class Solution {
    public bool RotateString(string s, string goal) {
        bool isSame = false;
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(goal) || s.Length != goal.Length) return isSame;

        // optimized version using span
        ReadOnlySpan<char> doubledSpan = (s + s).AsSpan();
        ReadOnlySpan<char> goalSpan = goal.AsSpan();
        for (int i = 0; i <= doubledSpan.Length - goalSpan.Length; i++)
        {
            if (doubledSpan.Slice(i, goalSpan.Length).SequenceEqual(goalSpan))
                return true;
        }
        return false;
        // string doubled = s + s;
        // for (int i = 0; i <= doubled.Length - goal.Length; i++)
        // {
        //     int j = 0;
        //     while (j < goal.Length && doubled[i + j] == goal[j])
        //         j++;
        //     if (j == goal.Length)
        //         return true;
        // }
        // return false;
    }
}