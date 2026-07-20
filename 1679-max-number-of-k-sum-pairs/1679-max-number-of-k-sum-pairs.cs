public class Solution {
    public int MaxOperations(int[] nums, int k) {

        Dictionary<int, int> hash = new();
        int counter=0;
        foreach (var n in nums)
        {
            var target = k-n;
            if(hash.ContainsKey(target) && hash[target]>0)
            {
                counter++;
                hash[target]--;
            }
            else
            {
                if(!hash.ContainsKey(n))
                    hash[n]=0;
                hash[n]++;
            }
        }
        return counter;
    }
}