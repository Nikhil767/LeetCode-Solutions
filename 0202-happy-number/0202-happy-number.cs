public class Solution {
    public bool IsHappy(int n) {
        if (n < 1) return false;
        int slow = n;
        int fast = SumOfSquares(n);
        while (fast != 1 && slow != fast)
        {
            slow = SumOfSquares(slow);
            fast = SumOfSquares(SumOfSquares(fast));
        }
        return fast == 1;
    }

    private int SumOfSquares(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        return sum;
    }
}