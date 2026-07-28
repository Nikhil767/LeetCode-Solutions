public class Solution {
    public string SmallestPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) return s;
        if (s.Length == 1) return s;

        int[] freq = new int[26];
        foreach (var c in s)
        {
            freq[c - 'a']++;
        }
        char? middleChar = null;
        StringBuilder sb = new(s.Length);
        for (int i = 0; i < freq.Length; i++)
        {
            var currentCount = freq[i];
            if ((freq[i] & 1) == 1)
            {
                // If more than one odd frequency, palindrome rearrangement is IMPOSSIBLE
                if (middleChar != null) return "";
                middleChar = (char)('a' + i);
            }
            var count = currentCount / 2;
            if (count > 0)
            {
                //char ch = (char)('a' + i);
                //for (int j = 0; j < count; j++)
                //	sb.Append(ch);
                sb.Append((char)('a' + i), count);
            }
        }
        // return the string by combining sb + revsere of sb;
        string firstHalf = sb.ToString();
        if (middleChar.HasValue)
            sb.Append(middleChar.Value);
        // Append second half in reverse order
        for (int i = firstHalf.Length - 1; i >= 0; i--)        
            sb.Append(firstHalf[i]);        
        return sb.ToString();
        // var firstString = middleChar != '\0' ? sb.ToString() + middleChar : sb.ToString();
        // return firstString + string.Create(sb.Length, sb, (span, state)=>
        // {
        //     var len = sb.Length-1;
        //     for (int i=0; i<sb.Length; i++)
        //     {
        //         span[i] = sb[len];
        //         len--;
        //     }
        // });
    }
}