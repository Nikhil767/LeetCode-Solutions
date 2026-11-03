public class Solution {
    public int MajorityElement(int[] nums) {
        if (nums is null || nums.Length < 1)
            return 0;
        int majorityCount = nums.Length >> 1;
        Dictionary<int,int> freq = new(nums.Length);

        foreach(var i in nums)
        {
            int count = freq.GetValueOrDefault(i) + 1;
            if (count > majorityCount)
                return i;
            freq[i] = count;
        }

        return -1;
    }
}