public class Solution {
    public int RomanToInt(string s) {
        if(string.IsNullOrEmpty(s)) return 0;
        Dictionary<char,int> data=new();
        data.Add('I',1);
        data.Add('V',5);
        data.Add('X',10);
        data.Add('L',50);
        data.Add('C',100);
        data.Add('D',500);
        data.Add('M',1000);
        int result=0;
        for (int i = 0; i < s.Length; i++)
        {
            int currentValue = data[s[i]];
            int nextValue = (i + 1 < s.Length) ? data[s[i + 1]] : 0;
            if (currentValue < nextValue)
                result -= currentValue;
            else
                result += currentValue;
        }
        return result;
    }
}