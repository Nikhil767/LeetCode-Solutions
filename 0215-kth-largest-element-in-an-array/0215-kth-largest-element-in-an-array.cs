public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        if (nums == null || nums.Length == 0)
            return 0;
        // Min-heap that will store only the top k largest elements
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>(k);
        foreach (int value in nums)
        {
            // If heap has space, simply add the value
            if (minHeap.Count < k)
            {
                minHeap.Enqueue(value, value);
                continue;
            }
            // Heap is full: compare with smallest (root)
            int smallestInHeap = minHeap.Peek();
            // If new value is larger, it belongs in the top k
            if (value > smallestInHeap)
            {
                minHeap.DequeueEnqueue(value, value); // remove smallest & insert new value
                //minHeap.Dequeue();          // remove smallest
                //minHeap.Enqueue(value, value); // insert new value
            }
        }
        // The root of the heap is the kth largest element
        return minHeap.Peek();
    }
}