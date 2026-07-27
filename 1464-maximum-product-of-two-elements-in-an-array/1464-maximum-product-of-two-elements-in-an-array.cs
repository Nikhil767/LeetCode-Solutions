public class Solution {
    public int MaxProduct(int[] nums) {
        int firstLargeNum=0;
        int secondLargeNum=0;
        for (int i=0; i< nums.Length; i++)
        {
            if(firstLargeNum < nums[i])
            {
                secondLargeNum = firstLargeNum;
                firstLargeNum = nums[i];
            }
            else if (secondLargeNum < nums[i])
                secondLargeNum = nums[i];
        }
        return (firstLargeNum-1)*(secondLargeNum-1);
    }
}