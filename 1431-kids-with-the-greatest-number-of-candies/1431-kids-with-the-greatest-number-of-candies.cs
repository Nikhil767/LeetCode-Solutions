public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        if(candies is null || candies.Length < 1 || extraCandies < 1) return null;
        bool[] result = new bool[candies.Length];
        var span = candies;
        int max = 0;
        int j=0;
        while (j<candies.Length)
        {
            if(span[j]>max)
                max=span[j];
            j++;
        }
        for (int i=0; i<candies.Length; i++)
        {
            if(span[i] + extraCandies >= max)
                result[i] = true;
        }
        return result;
    }
}