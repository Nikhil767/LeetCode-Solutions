public class Solution {
    public bool IsPalindrome(string s) {        
        if(string.IsNullOrEmpty(s)) return false;        
        var span = s.AsSpan();
        var start = 0;
        var end = span.Length-1;        
        while(start<= end)
        {
            if(!char.IsLetterOrDigit(span[end]))
            {
                end--;
                continue;
            }
            if(!char.IsLetterOrDigit(span[start]))
            {
                start++;
                continue;
            }
            if((span[start] | 0x20) != (span[end] | 0x20))
            {
                return false;
            }
            start++;
            end--;
        }        
        return true;
    }
}