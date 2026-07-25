public class Solution {
    public int PivotIndex(int[] nums) {
        var k = nums.Length;
        int totalSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            totalSum += nums[i];
        }
        int sumLeft = 0;
        int sumRight = 0;
        for (int i = 0; i < k; i++)
        {
            sumRight = totalSum - sumLeft - nums[i];
            if (sumLeft == sumRight)
                return i;
            sumLeft += nums[i];
        }
        return -1;
    }
}