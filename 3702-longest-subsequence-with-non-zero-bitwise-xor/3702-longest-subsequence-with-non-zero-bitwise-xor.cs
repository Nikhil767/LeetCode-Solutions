public class Solution {
    public int LongestSubsequence(int[] nums) {
        if (nums is null || nums.Length < 1) return 0;
        int n = nums.Length;
        // Check if all elements are zero
        bool allZero = true;
        foreach (int x in nums)
        {
            if (x != 0)
            {
                allZero = false;
                break;
            }
        }

        if (allZero)
            return 0;

        // Compute XOR of all elements
        int totalXor = 0;
        foreach (int x in nums)
            totalXor ^= x;

        // If XOR of all is non-zero → longest subsequence is full array
        if (totalXor != 0)
            return n;

        // If XOR of all is zero → remove any one element
        return n - 1;
    }
}