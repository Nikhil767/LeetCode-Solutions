public class Solution {
    public string ToLowerCase(string s) {
        if(string.IsNullOrWhiteSpace(s)) return s;
        StringBuilder sb = new(s.Length);
        foreach(char c in s)
        {
            if(Char.IsUpper(c))
                sb.Append((char)(c | 0x20));
            else
                sb.Append(c);
        }
        return sb.ToString();
    }
}