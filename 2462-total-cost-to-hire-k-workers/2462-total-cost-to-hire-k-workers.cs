public class Solution {
    public long TotalCost(int[] costs, int k, int candidates) {
        int n = costs.Length;
        long total = 0;

        var leftHeap = new PriorityQueue<int, int>();
        var rightHeap = new PriorityQueue<int, int>();

        int l = 0, r = n - 1;

        // Fill left heap
        for (int i = 0; i < candidates && l <= r; i++)
            leftHeap.Enqueue(costs[l], costs[l++]);

        // Fill right heap
        for (int i = 0; i < candidates && l <= r; i++)
            rightHeap.Enqueue(costs[r], costs[r--]);

        while (k-- > 0)
        {
            bool pickLeft;

            if (leftHeap.Count > 0 && rightHeap.Count > 0)
                pickLeft = leftHeap.Peek() <= rightHeap.Peek();
            else
                pickLeft = rightHeap.Count == 0;

            if (pickLeft)
            {
                total += leftHeap.Dequeue();

                if (l <= r)
                    leftHeap.Enqueue(costs[l], costs[l++]);
            }
            else
            {
                total += rightHeap.Dequeue();

                if (l <= r)
                    rightHeap.Enqueue(costs[r], costs[r--]);
            }
        }

        return total;       
    }
}