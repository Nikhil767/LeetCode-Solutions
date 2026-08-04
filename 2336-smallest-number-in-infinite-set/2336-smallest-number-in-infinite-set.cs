public class SmallestInfiniteSet {
    int current=1;
    PriorityQueue<int, int> minHeap = null;
    HashSet<int> unique = null;
    public SmallestInfiniteSet() {
        unique = new();
        minHeap = new PriorityQueue<int, int>();
    }
    
    public int PopSmallest() {
        if(minHeap.Count < 1)
        {
            var result = current;
            current++;
            return result;
        }
        else
        {
            var remove = minHeap.Dequeue();
            unique.Remove(remove);
            return remove;
        }            
    }
    
    public void AddBack(int num) {
        if(num < current && !unique.Contains(num))
        {
            minHeap.Enqueue(num, num);
            unique.Add(num);
        }
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */