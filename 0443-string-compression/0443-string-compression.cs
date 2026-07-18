public class Solution {
    public int Compress(char[] chars) {
        if(chars is null || chars.Length < 1) return 0;
        if(chars.Length == 1) return chars.Length;
        var span = chars.AsSpan();
        int counter = 1;
        int write = 0;
        for (int i=0; i< span.Length; i++)
        {
            if(i == span.Length-1 || span[i] != span[i+1])
            {      
                span[write] = span[i];
                    write++;          
                if(counter > 1)
                {                    
                    foreach (var digit in counter.ToString())
                    {
                        span[write] = digit;
                        write++;
                    }
                }   
                counter = 1;
            }
            else
            {
                counter++;
            }
        }
        return write;
    }
}