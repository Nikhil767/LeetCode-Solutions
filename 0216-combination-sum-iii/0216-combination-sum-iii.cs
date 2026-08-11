public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var result = new List<IList<int>>();
        Backtrack(1, k, n, new List<int>(), result);
        return result;
    }

    private void Backtrack(int start, int k, int target, List<int> current, IList<IList<int>> result)
    {
        // If we have chosen k numbers and hit the target, add the combination
        if (current.Count == k && target == 0)
        {
            result.Add(new List<int>(current));
            return;
        }

        // If we exceed limits, stop exploring
        if (current.Count > k || target < 0)
            return;

        // Explore numbers 1–9
        for (int num = start; num <= 9; num++)
        {
            current.Add(num);
            Backtrack(num + 1, k, target - num, current, result);
            current.RemoveAt(current.Count - 1); // backtrack
        }
    }
}