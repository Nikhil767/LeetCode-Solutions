public class Solution {
    public int MinimumPushes(string word) {
        int pushes = 1;
        int totalCost = 0;
        int length = word.Length;
        while (length > 0)
        {
            int lettersInThisBatch = Math.Min(length, 8); // Take up to 8 letters
            totalCost += lettersInThisBatch * pushes;            
            length -= lettersInThisBatch; // Reduce remaining length
            pushes++;                     // Next batch costs 1 extra push
        }
        return totalCost;
    }
}