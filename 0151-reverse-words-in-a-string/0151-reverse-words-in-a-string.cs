public class Solution {
    public string ReverseWords(string s) {
        if(string.IsNullOrEmpty(s) || s.Length == 1) return s;
        var span = s.AsSpan();
        StringBuilder sb = new(s.Length);
        int lastIndex = s.Length-1;
        while(lastIndex >= 0)
        {
            if(span[lastIndex] == ' ')
                lastIndex--;
            else
            {
                int end=lastIndex;         
                while(lastIndex > -1 && span[lastIndex] != ' ')
                {
                    lastIndex--;
                }
                int start=lastIndex+1;
                for (int j=start;j<=end; j++)
                {
                    sb.Append(span[j]);
                }              
                sb.Append(' ');
            }
        }
        return sb.ToString().Trim(' ');
    }
}