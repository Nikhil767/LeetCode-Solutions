public class RecentCounter {

    private readonly int threshold=3000;
    private readonly Queue<int> freq = null;
    public RecentCounter() {
        freq = new();
    }
    
    public int Ping(int t) {        
        freq.Enqueue(t);
        while (freq.TryPeek(out int element) && element < (t-threshold))        
            freq.Dequeue(); // Removes the element        
        return freq.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */