public class Solution {
    public string AddBinary(string a, string b) {
        if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b)) return "";
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;
        var sb = new StringBuilder(i + j);
        while (i >= 0 || j >= 0 || carry == 1)
        {
            int sum = carry;
            if (i >= 0)
            {
                sum = sum + a[i] - '0';
                i--;
            }
            if (j >= 0)
            {
                sum = sum + b[j] - '0';
                j--;
            }                
            sb.Append(sum % 2);
            carry = sum / 2;
        }
        // reverse because we built from right to left
        // char[] arr = sb.ToString().ToCharArray();
        // Array.Reverse(arr);
        // return new string(arr);
        return String.Create(sb.Length, sb, (span, source)=>
        {
            int len = source.Length-1;
            for (int i=0; i<source.Length; i++)
            {
                span[i] = source[len];
                len--;
            }
        });
    }
}