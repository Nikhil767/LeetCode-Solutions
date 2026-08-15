public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        // Sort by end time
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        int count = 0;
        int lastEnd = intervals[0][1];
        for (int i = 1; i < intervals.Length; i++)
        {
            // If overlapping, remove it
            if (intervals[i][0] < lastEnd)
            {
                count++;
            }
            else
            {
                // Otherwise keep it
                lastEnd = intervals[i][1];
            }
        }
        return count;
    }
}