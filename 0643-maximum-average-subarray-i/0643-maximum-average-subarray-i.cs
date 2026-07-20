public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        if(k < 1) return double.MinValue;
        int n = nums.Length;
        double maxavg = Double.MinValue;
        double windowSum = 0;
        int start = 0;
        for (int end = 0; end < n; end++)
        {
            windowSum += nums[end]; // add new element
            // once window size reaches k
            if (end >= k - 1)
            {
                var maxavgNew = windowSum / k; // compute average
                if(maxavg < maxavgNew)
                    maxavg = maxavgNew;
                windowSum -= nums[start]; // remove element leaving window
                start++; // slide window
            }
        }
        return maxavg;
    }
}