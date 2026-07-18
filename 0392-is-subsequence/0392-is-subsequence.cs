public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(string.IsNullOrEmpty(s)) return true;
        if(string.IsNullOrEmpty(t)) return false;
        if(t.Length < s.Length) return false;

        var spanS = s.AsSpan();
        var spanT = t.AsSpan();
        int i=0;
        int j=0;
        while (i < spanS.Length && j < spanT.Length)
        {
            if(spanS[i] == spanT[j])
                i++;
            j++;
        }       
        return i == spanS.Length;
    }
}