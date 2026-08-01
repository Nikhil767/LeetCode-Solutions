public class Solution {
    public int FindDuplicate(int[] nums) {
        int slow = nums[0];
        int fast = nums[nums[0]];
        // Phase 1: Detect cycle
        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
        // Phase 2: Find entry point of cycle (duplicate)
        fast = 0;
        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }
        return slow;
    }
}