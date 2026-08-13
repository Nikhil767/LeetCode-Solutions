public class Solution {
    public string IntToRoman(int num) {
        if(num < 1) return "";
        var pairs = new (int Value, string Symbol)[]
            {
                (1000, "M"),
                (900,  "CM"),
                (500,  "D"),
                (400,  "CD"),
                (100,  "C"),
                (90,   "XC"),
                (50,   "L"),
                (40,   "XL"),
                (10,   "X"),
                (9,    "IX"),
                (5,    "V"),
                (4,    "IV"),
                (1,    "I")
            };
        StringBuilder sb=new();        
        foreach (var (value, symbol) in pairs)
        {
            while (num >= value)
            {
                sb.Append(symbol);
                num -= value;
            }
        }
        return sb.ToString();
    }
}