public class Solution {
    public int LengthOfLastWord(string s) {
        if(string.IsNullOrEmpty(s)) return 0;
        int length=0;
        for (int i=s.Length-1; i>=0; i--)
        {
            var isWhiteSpace = Char.IsWhiteSpace(s[i]);
            if(!isWhiteSpace)
                length++;
            else if(isWhiteSpace && length > 0)
                break;
        }
        return length;
    }
}