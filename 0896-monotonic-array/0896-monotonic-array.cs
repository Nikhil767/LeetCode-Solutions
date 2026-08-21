public class Solution {
    public bool IsMonotonic(int[] nums) {
        if(nums is null || nums.Length < 1) return false;
        bool isIncreasing = true;
        bool isDecreasing = true;
        int n = nums.Length;
        for (int i=0; i<=n-2; i++)
        {
            if(nums[i] < nums[i+1])
                isDecreasing=false;
        }
        for (int i=0; i<=n-2; i++)
        {
            if(nums[i] > nums[i+1])
                isIncreasing=false;
        }
        return isIncreasing || isDecreasing ? true : false;
    }
}