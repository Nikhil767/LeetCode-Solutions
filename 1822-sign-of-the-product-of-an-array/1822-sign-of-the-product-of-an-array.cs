public class Solution {
    public int ArraySign(int[] nums) {
        if (nums is null || nums.Length < 1) return 0;
        long product = 1;
        foreach (int num in nums)
            product = num == 0 ? num * product : (num > 0 ? 1 * product : -1 * product);

        if (product == 0)
            return 0;
        else if (product > 0)
            return 1;
        else
            return -1;
    }
}