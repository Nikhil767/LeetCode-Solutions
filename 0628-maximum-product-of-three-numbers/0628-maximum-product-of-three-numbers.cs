public class Solution {
    public int MaximumProduct(int[] nums) {
        int firstMax=int.MinValue;
        int secondMax=int.MinValue;
        int thirdMax=int.MinValue;
        int min1 = int.MaxValue, min2 = int.MaxValue;
        for (int i=0; i<nums.Length; i++)
        {
            var currentNum = nums[i];
            // Update smallest
            if (currentNum < min1)
            {
                min2 = min1;
                min1 = currentNum;
            }
            else if (currentNum < min2)
            {
                min2 = currentNum;
            }
            // Update largest
            if(currentNum > firstMax)
            {
                thirdMax=secondMax;
                secondMax=firstMax;
                firstMax=currentNum;
            }
            else if (currentNum > secondMax)
            {
                thirdMax=secondMax;
                secondMax=currentNum;
            }
            else if (currentNum > thirdMax)
                thirdMax=currentNum;
        }
        int product1 = firstMax*secondMax*thirdMax;  // three largest
        int product2 = min1 * min2 * firstMax;       // two smallest (negatives) * largest
        return Math.Max(product1, product2);;
    }
}