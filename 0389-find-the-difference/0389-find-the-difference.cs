public class Solution {
    public char FindTheDifference(string s, string t) {
        if(string.IsNullOrEmpty(s)) return t[0];
        int[] freq= new int[26];

        for (int i=0; i<s.Length; i++)
        {
            freq[s[i] - 'a']++;
            freq[t[i] - 'a']--;
        }
        freq[t[s.Length] - 'a']--;

        for (int i = 0; i < freq.Length; i++)
        {
            if (freq[i] != 0)
            {
                return (char)(i + 'a');
            }
        }
        return '\0';
    }
}