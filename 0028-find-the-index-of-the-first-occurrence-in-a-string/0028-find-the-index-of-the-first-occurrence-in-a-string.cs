public class Solution {
    public int StrStr(string haystack, string needle) {
        if(string.IsNullOrEmpty(haystack) || string.IsNullOrEmpty(needle)) return -1;
        if (needle.Length == 0) return 0;
        int first = 0;
        int second = 0;
        while (first < haystack.Length)
        {
            // If characters match, move both pointers
            if (haystack[first] == needle[second])
            {
                second++;
                // Full match found
                if (second == needle.Length)
                    return first - second + 1;
            }
            else
            {
                // Mismatch: rewind first to next possible start
                first = first - second;
                second = 0;
            }
            first++;
        }
        return -1;
    }
}