public class Solution {
    public int LengthOfLastWord(string s) {
        if(string.IsNullOrEmpty(s)) return 0;
        int length=0;
        for (int i=s.Length-1; i>=0; i--)
        {
            var isChar = Char.IsWhiteSpace(s[i]);
            if(!isChar)
                length++;
            else if(isChar && length > 0)
                break;
        }
        return length;
    }
}