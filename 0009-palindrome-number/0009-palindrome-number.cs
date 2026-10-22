public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0 || (x % 10 == 0 && x != 0)) 
            return false;
        int reversedHalf = 0;
        while (x > reversedHalf)
        {
            reversedHalf = reversedHalf * 10 + x % 10;
            x /= 10;
        }
        return x == reversedHalf || x == reversedHalf / 10;

        // int temp = x;
        // int reverse=0;        
        // while (temp > 0)
        // {
        //     reverse = reverse * 10 + temp % 10;
        //     temp /= 10;
        // }
        // return x == reverse;
    }
}