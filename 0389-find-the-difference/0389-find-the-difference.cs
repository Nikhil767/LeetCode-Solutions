public class Solution {
    public char FindTheDifference(string s, string t) {
        if(string.IsNullOrEmpty(s)) return t[0];
        const char a='a';
        int[] freq= new int[26];

        for (int i=0; i<s.Length; i++)
        {
            freq[s[i] - a]++;
            freq[t[i] - a]--;
        }
        freq[t[s.Length] - a]--;

        for (int i=0; i<freq.Length; i++)
        {
            if (freq[i] != 0)            
                return (char)(i + a);            
        }
        return '\0';
    }

    public char FindTheDifferenceWithXOR(string s, string t)
    {
        if (string.IsNullOrEmpty(s)) return t[0];
        int result = 0;
        foreach (var item in s)        
            result ^= item;
        
        foreach (var item in t)        
            result ^= item;
        
        return (char)result;
    }
}