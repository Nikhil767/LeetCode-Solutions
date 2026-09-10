public class Solution {
    public int LargestPerimeter(int[] nums) {
        Array.Sort(nums);
        for (int i = nums.Length - 1; i >= 2; i--)
        {
            int a = nums[i];
            int b = nums[i - 1];
            int c = nums[i - 2];

            // Triangle condition: sum of smaller two > largest
            if (b + c > a)
                return a + b + c;
        }
        return 0;
    }
}