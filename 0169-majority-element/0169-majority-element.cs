public class Solution {
    public int MajorityElement(int[] nums) {
        if (nums is null || nums.Length < 1)
            return -1;

        return MajorityElementOP(nums);

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

    public int MajorityElementOP(int[] nums)
    {
        int candidate = 0;
        int count = 0;

        foreach (int num in nums)
        {
            if (count == 0)
                candidate = num;

            count += (num == candidate) ? 1 : -1;
        }

        return candidate;
    }
}