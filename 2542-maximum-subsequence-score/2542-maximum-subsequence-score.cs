public class Solution {
    public long MaxScore(int[] nums1, int[] nums2, int k) {
        int n = nums1.Length;
        var pairs = new List<(int n2, int n1)>();

        for (int i = 0; i < n; i++)
            pairs.Add((nums2[i], nums1[i]));

        // Sort by nums2 descending
        pairs.Sort((a, b) => b.n2.CompareTo(a.n2));

        var minHeap = new PriorityQueue<int, int>();
        long sum = 0, result = 0;

        foreach (var (n2, n1) in pairs)
        {
            minHeap.Enqueue(n1, n1);
            sum += n1;

            if (minHeap.Count > k)
                sum -= minHeap.Dequeue();

            if (minHeap.Count == k)
                result = Math.Max(result, sum * n2);
        }

        return result;
    }
}