public class Solution {
    public string ToLowerCase(string s) {
        if(string.IsNullOrWhiteSpace(s)) return s;

        // with String.Create
        return string.Create(s.Length, s, (span, input)=>
        {
            const uint UpperRange = 'Z' - 'A'; // 25
            for(int i=0; i<input.Length; i++)
            {
                char c =input[i];
                 if((uint)(c - 'A') <= UpperRange)
                    span[i] = (char)(c | 0x20);
                else
                    span[i] = c;
            }
        });
        // // with StringBuilder
        // StringBuilder sb = new(s.Length);
        // foreach(char c in s)
        // {
        //     if(Char.IsUpper(c))
        //         sb.Append((char)(c | 0x20));
        //     else
        //         sb.Append(c);
        // }
        // return sb.ToString();
    }
}