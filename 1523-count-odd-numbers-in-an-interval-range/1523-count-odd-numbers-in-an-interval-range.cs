public class Solution {
    public int CountOdds(int low, int high) {
        if (low > high) return 0;
        bool isEven = ((high - low + 1) & 1) == 0;

        int oddCounter = 0;
        for (int i = low; i <= high; i++)
        {
            if((i & 1) == 1)
                oddCounter++;
        }
        return oddCounter;
    }
}