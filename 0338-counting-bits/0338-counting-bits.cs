public class Solution {
    public int[] CountBits(int n) {
        int[] bits = new int[n+1];
        bits[0]=0;
        for (int i =1; i<bits.Length; i++)
        {
            bits[i] = bits[i/2] + (i & 1);
        }
        return bits;
    }
}