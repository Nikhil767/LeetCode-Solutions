public class Solution {
    public int UniqueXorTriplets(int[] nums) {
        // Step 1: Extract unique elements from nums
        HashSet<int> uniqueNums = new HashSet<int>(nums);        
        // Step 2: Compute all unique pair XORs (a ^ b)
        // Using a HashSet or boolean array to keep track of unique pair XORs
        HashSet<int> pairXors = new HashSet<int>();        
        for (int i = 0; i < nums.Length; i++)
            for (int j = i; j < nums.Length; j++) 
                pairXors.Add(nums[i] ^ nums[j]);
        // Step 3: Combine pair XORs with all unique single values
        HashSet<int> tripletXors = new HashSet<int>();
        foreach (int p in pairXors)
            foreach (int u in uniqueNums) 
                tripletXors.Add(p ^ u);
        return tripletXors.Count;

        // HashSet<int> uniqueNums = new HashSet<int>();
        // for (int i = 0; i < nums.Length; i++)        
        //     for (int j = i; j < nums.Length; j++)            
        //         for (int k = j; k < nums.Length; k++)                
        //             uniqueNums.Add(nums[i] ^ nums[j] ^ nums[k]);               
        // return uniqueNums.Count;
    }
}