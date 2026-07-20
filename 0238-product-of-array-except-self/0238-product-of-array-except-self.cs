public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] result = new int[n];

        result[0] = 1;
        for (int i=1; i< n; i++)
        {
            result[i] = nums[i-1] * result[i-1];
        }
        int suffix = 1;
        for (int j=n-1; j>=0; j--)
        {
            result[j] = result[j] * suffix;
            suffix = suffix* nums[j];
        }
        return result;
    }
}