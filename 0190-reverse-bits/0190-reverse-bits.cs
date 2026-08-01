public class Solution {
    public int ReverseBits(int n) {
        int result=0;
        for (int i=0; i<32; i++)
        {
            result <<= 1; // Shift existing bits in result one position to the left.
            result |= n&1; // Extract the last bit of n and append the last bit to result left
            n >>>= 1; // Shift n one position to the right using Unsigned Right Shift (>>>)         
        }
        return result;
    }
}