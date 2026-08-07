public class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);
        int m = potions.Length;
        int[] result = new int[spells.Length];

        for (int i = 0; i < spells.Length; i++)
        {
            long required = (success + spells[i] - 1) / spells[i]; // ceil(success / spell)
            int idx = LowerBound(potions, required);
            result[i] = m - idx;
        }

        return result;
    }

    private int LowerBound(int[] arr, long target)
    {
        int left = 0, right = arr.Length;

        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid;
        }

        return left;
    }
}