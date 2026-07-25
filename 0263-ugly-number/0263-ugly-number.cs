public class Solution {
    public bool IsUgly(int n) {
        if(n < 1) return false;
        int[] factors = { 2, 3, 5 };
        foreach (var f in factors)
        {
            while (n % f == 0)            
                n /= f;            
        }
        return n == 1;
    }
}