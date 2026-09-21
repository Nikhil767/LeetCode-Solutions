public class Solution {
    public bool IsPalindrome(string s) {        
        if(string.IsNullOrEmpty(s)) return false;        
        var span = s.AsSpan();
        var start = 0;
        var end = span.Length-1;        
        while(start<= end)
        {
            bool isFirstLetter = char.IsLetterOrDigit(span[start]);
            bool isLastLetter = char.IsLetterOrDigit(span[end]);
            if(!isLastLetter)
            {
                end--;
                continue;
            }
            if(!isFirstLetter)
            {
                start++;
                continue;
            }
            else if((span[start] | 0x20) != (span[end] | 0x20))
            {
                return false;
            }
            start++;
            end--;
        }        
        return true;
    }
}