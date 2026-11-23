public class MedianFinder {
    private PriorityQueue<int, int> minHeap;
    private PriorityQueue<int, int> maxHeap;
    public MedianFinder() {
        minHeap = new PriorityQueue<int, int>();
        maxHeap = new PriorityQueue<int, int>();
    }
    
    public void AddNum(int num) {
        maxHeap.Enqueue(num, -num);

        int maxTop = maxHeap.Dequeue();
        minHeap.Enqueue(maxTop, maxTop);

        if (minHeap.Count > maxHeap.Count)
        {
            int minTop = minHeap.Dequeue();
            maxHeap.Enqueue(minTop, -minTop);
        }
    }
    
    public double FindMedian() {
        if (maxHeap.Count > minHeap.Count)
            return maxHeap.Peek();

        return (maxHeap.Peek() + minHeap.Peek()) / 2.0;
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */