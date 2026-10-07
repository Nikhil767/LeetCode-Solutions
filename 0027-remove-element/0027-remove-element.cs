public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if (nums is null || nums.Length < 1 || val < 0) return 0;
        int left = 0;
        int right = nums.Length-1;
        while(left <= right)
        {
            var currentValue = nums[left];
            var lastValue = nums[right];
            if(currentValue == val && lastValue == val)
            {
                right--;
                continue;
            }
            else if(currentValue == val)
            {
                var t = nums[left];
                nums[left] = nums[right];
                nums[right] = t;
                right--;
            }
            left++;
        }
        return left;
    }
}