public class Solution {
    public int[] PlusOne(int[] digits) {
        if(digits is null || digits.Length < 1) return digits;
        
        return Op(digits);
        //return WithBigInteger(digits);
    }

    private int[] Op(int[] digits)
    {
        // Traverse from right to left
        for (int i = digits.Length - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i]++;      // no carry needed
                return digits;    // done
            }
            digits[i] = 0;        // set to 0 and continue carry
        }

        // If we reach here, all digits were 9 (e.g. 999 -> 1000)
        var result = new int[digits.Length + 1];
        result[0] = 1;            // 1 followed by all 0s
        return result;
    }

    private int[] WithBigInteger(int[] digits)
    {
        // used BigInteger for large numbers
        System.Numerics.BigInteger num=0;
        foreach(int n in digits)
        {
            num = num * 10 + n; 
        }
        // add 1 to the real number
        num = num+1;
        List<int> newDigits=new(digits.Length+1);
        while(num>0)
        {
            int rem = (int)(num % 10);;
            newDigits.Add(rem);
            num = num / 10;
        }
        var result = newDigits.ToArray();

        // reverse array in place
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