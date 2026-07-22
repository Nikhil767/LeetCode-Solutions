public class Solution {
    public string DecodeString(string s) {        
        var span = s.AsSpan();
        Stack<(int count, StringBuilder sb)> stack = new(s.Length);
        StringBuilder currentStr = new();
        int currentCount = 0;
        for (int i = 0; i < span.Length; i++) {
            char ch = span[i];
            if (char.IsDigit(ch)) {
                // Handle multi-digit numbers like "10[a]"
                currentCount = currentCount * 10 + (ch - '0');
            } 
            else if (ch == '[') {
                // Save previous context onto the stack and reset state for inside brackets
                stack.Push((currentCount, currentStr));
                currentStr = new StringBuilder();
                currentCount = 0;
            } 
            else if (ch == ']') {
                // Retrieve outer context
                var (repeatCount, prevStr) = stack.Pop();                
                // Repeat current string and append to outer string
                for (int r = 0; r < repeatCount; r++)
                    prevStr.Append(currentStr);                                
                currentStr = prevStr;
            } 
            else {
                // Append regular characters
                currentStr.Append(ch);
            }
        }
        return currentStr.ToString();
    }
}