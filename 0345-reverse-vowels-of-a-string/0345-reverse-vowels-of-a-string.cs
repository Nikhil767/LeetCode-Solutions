public class Solution {
    public string ReverseVowels(string s) {
        
        if(string.IsNullOrWhiteSpace(s)) return s;
        int startIndex=0;
        int endIndex=s.Length-1;
        char[] S = s.ToCharArray();
        Span<char> span = S;
        s.AsSpan().CopyTo(span);
        while(startIndex<endIndex)
        {
            var isFirst = IsVowel(span[startIndex]);
            var isLast = IsVowel(span[endIndex]);
            if(!isLast)            
            {
                endIndex--;
                continue;            
            }
            else if(!isFirst)
            {
                startIndex++;
                continue;
            }
            char t = span[startIndex];
            span[startIndex] = span[endIndex];
            span[endIndex] = t;
            startIndex++;
            endIndex--;            
        }
        return new string(S);
    }

    public bool IsVowel(char c)
    {
        return "aeiouAEIOU".AsSpan().IndexOf(c) >= 0;
    }
}