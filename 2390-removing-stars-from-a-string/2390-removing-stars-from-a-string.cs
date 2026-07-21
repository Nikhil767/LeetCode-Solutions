public class Solution {
    public string RemoveStars(string s) {
        if(string.IsNullOrEmpty(s)) return "";
        Stack<char> data = new(s.Length);
        int start=0;
        while(start<s.Length)
        {
            if(s[start] == '*')            
                data.Pop();            
            else
                data.Push(s[start]);
            start++;
        }
        var count = data.Count;
        return String.Create(count, data, (span, state)=>
        {
            int i = count-1;
            while(state.Count > 0)
            {
                span[i] = state.Pop();
                i--;
            }
        });
    }
}