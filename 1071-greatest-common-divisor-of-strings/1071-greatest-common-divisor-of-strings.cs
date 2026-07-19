public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if(string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2)) return "";
        if (!AreConcatsEqual(str1.AsSpan(), str2.AsSpan()))
            return "";
        
        var counter = GCD(str1.Length, str2.Length);
        return str1.Substring(0, counter);
    }
    public int GCD(int len1, int len2)
    {
        if(len2 == 0) return len1;
        return GCD (len2, len1 % len2);
    }
    private static bool AreConcatsEqual(ReadOnlySpan<char> s1, ReadOnlySpan<char> s2)
    {
        int len1 = s1.Length;
        int len2 = s2.Length;
        // Total length of virtual concatenation
        int total = len1 + len2;
        for (int i = 0; i < total; i++)
        {
            // (s1 + s2)[i]
            char c1 = i < len1 ? s1[i] : s2[i - len1];
            // (s2 + s1)[i]
            char c2 = i < len2 ? s2[i] : s1[i - len2];
            if (c1 != c2)
                return false;
        }
        return true;
    }
}