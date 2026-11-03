public class Solution {
    public int MajorityElement(int[] nums) {
        if (nums is null || nums.Length < 1)
            return 0;
        int majorityCount = nums.Length / 2;
        Dictionary<int,int> freq = new(nums.Length);

        foreach(var i in nums)
        {
            freq[i] = freq.GetValueOrDefault(i,0) + 1;
        }

        return freq.FirstOrDefault(x=> x.Value > majorityCount).Key;
    }
}