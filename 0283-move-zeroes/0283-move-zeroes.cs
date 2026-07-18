public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums is not null && nums.Length > 1)
        {
            var span = nums.AsSpan();
            int j=0;
            for(int i=0; i< nums.Length; i++)
            {
                if(span[i]!=0)
                {
                    int t = span[i];
                    span[i] = span[j];
                    span[j] = t;
                    // (span[i], span[j]) = (span[j], span[i])
                    j++;
                }
            }
        }
    }
}