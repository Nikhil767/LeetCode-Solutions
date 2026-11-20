public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
    int longest = 0;

    foreach (int num in set)
    {
        if (!set.Contains(num - 1))
        {
            int currentNum = num;
            int currentStreak = 1;

            while (set.Contains(currentNum + 1))
            {
                currentNum++;
                currentStreak++;
            }

            longest = Math.Max(longest, currentStreak);
        }
    }

    return longest;
    }
}