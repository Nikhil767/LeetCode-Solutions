public class Solution {
    public bool UniqueOccurrences(int[] arr) {        
        Dictionary<int, int> freq = new(arr.Length);
        for (int i =0; i<arr.Length; i++)
        {
            if(!freq.ContainsKey(arr[i]))
            {
                freq[arr[i]] = 1;
            }
            else
            {
                freq[arr[i]]++;
            }
        }
        //return freq.Values.Distinct().Count() == freq.Count;
        // Check uniqueness using a HashSet
        HashSet<int> seen = new(freq.Count);
        foreach (int count in freq.Values)
        {
            if (!seen.Add(count))   // Add returns false if count already exists
                return false;
        }
        return true;
    }
}