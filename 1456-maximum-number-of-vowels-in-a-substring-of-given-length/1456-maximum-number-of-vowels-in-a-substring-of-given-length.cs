public class Solution {
    public int MaxVowels(string s, int k) {
        if(k < 1 || string.IsNullOrEmpty(s)) return 0;
        int count = 0;
        int max = 0;
        ReadOnlySpan<char> span = s.AsSpan();
        for (int end = 0; end < span.Length; end++)
        {
            if (IsVowel(span[end]))
                count++;
            if (end >= k)
            {
                if (IsVowel(span[end - k]))
                    count--;
            }
            if (count > max)
                max = count;
            if (max == k)
                return k; // early exit
        }
        return max;
    }

    public static bool IsVowel(char c)
    {
        return c is 'a' or 'e' or 'i' or 'o' or 'u';
    }
}