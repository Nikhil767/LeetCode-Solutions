public class Solution {
    public int CountOdds(int low, int high) {
        if (low > high) return 0;

        // optimzed solution with O(1)
        var total = high-low+1;
        var oddCounter = total / 2;
        if((low & 1) == 1 && (high & 1) == 1)
            oddCounter++;

        // O(n) solution
        // bool isEven = ((high - low + 1) & 1) == 0;
        // int oddCounter = 0;
        // for (int i = low; i <= high; i++)
        // {
        //     if((i & 1) == 1)
        //         oddCounter++;
        // }
        return oddCounter;
    }
}