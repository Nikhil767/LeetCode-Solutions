public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        if (s.Length <= 1)
	        return false;
        string doubled = s + s;
        // Search for s in doubled, starting from index 1.
        // If found at an index < s.Length, then s has a repeated pattern.
        int idx = doubled.IndexOf(s, 1);
        return idx != -1 && idx < s.Length;
    }
}