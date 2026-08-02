public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n; // normalize k so it’s within [0, n-1]
        Reverse(nums, 0, n - 1); // Reverse the entire array
        Reverse(nums, 0, k - 1); // Reverse the first k elements
        Reverse(nums, k, n - 1); // Reverse the remaining n - k elements
    }

    public void Reverse(int[] nums, int left, int right)
    {
        while (left < right)
        {
            int temp = nums[right];
            nums[right] = nums[left];
            nums[left] = temp;
            left++;
            right--;
        }
    }
}