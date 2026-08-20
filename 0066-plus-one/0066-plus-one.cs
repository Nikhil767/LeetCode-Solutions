public class Solution {
    public int[] PlusOne(int[] digits) {
        if(digits is null || digits.Length < 1) return digits;
        System.Numerics.BigInteger num=0;
        foreach(int n in digits)
        {
            num = num * 10 + n; 
        }
        num = num+1;
        List<int> newDigits=new(digits.Length+1);
        while(num>0)
        {
            int rem = (int)(num % 10);;
            newDigits.Add(rem);
            num = num / 10;
        }
        var result = newDigits.ToArray();
        int start=0;        
        int end=result.Length-1;
        while (start < end)
        {
            var t = result[start];
            result[start] = result[end];
            result[end] = t;
            start++;
            end--; 
        }
        return result;
    }
}