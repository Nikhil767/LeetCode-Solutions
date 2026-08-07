public class Solution {
    public int FindPeakElement(int[] nums) {
        int left = 0, right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] < nums[mid + 1])
                left = mid + 1;   // peak is on the right
            else
                right = mid;      // peak is on the left or at mid
        }

        return left; // or right, both are same here
    }
}