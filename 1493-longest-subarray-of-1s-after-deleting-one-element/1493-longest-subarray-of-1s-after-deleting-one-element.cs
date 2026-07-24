public class Solution {
    public int LongestSubarray(int[] nums) {
        int left = 0;
        int k = 1; // Allowance of 1 zero to delete
        int right = 0;
        for (right = 0; right < nums.Length; right++) 
        {
            if (nums[right] == 0)
                k--;
            // If window has more than 1 zero, slide left forward by 1 step
            if (k < 0) 
            {
                if (nums[left] == 0)
                    k++;
                left++;
            }
        }
        // Window size (right - left) automatically subtracts 1 for the deleted element!
        return right - left - 1;
    }
}