public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        List<int> first = new(nums1.Length);
        List<int> second = new(nums2.Length);
        HashSet<int> firstH = new(nums1);
        HashSet<int> secondH = new(nums2);
        foreach (var item in firstH)
        {
            if(!secondH.Contains(item))
                first.Add(item);
        }
        foreach (var item in secondH)
        {
            if(!firstH.Contains(item))
                second.Add(item);
        }    
        var result = new List<IList<int>>(2);
        result.Add(first);
        result.Add(second);
        return result;
    }
}