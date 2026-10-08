public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums is null || nums.Length < 1) return 0;
        int write = 1;        
        for (int read=1; read<nums.Length; read++)
        {
            if(nums[read] != nums[read-1])
            {
                nums[write] = nums[read];
                write++;
            }
        }
        return write;
    }
}