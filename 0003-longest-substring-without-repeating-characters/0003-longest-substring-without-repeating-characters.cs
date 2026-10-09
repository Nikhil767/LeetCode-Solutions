public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s is null || s.Length < 0) return 0;
        int left = 0;
        int maxLen = 0;
        HashSet<char> freq = new(s.Length);
        for (int right = 0; right < s.Length; right++)
        {
            while (freq.Contains(s[right]))
            {
                freq.Remove(s[left]);
                left++;
            }
            freq.Add(s[right]); 
            maxLen = Math.Max(maxLen, right-left+1);
        }
        return maxLen;
    }
}