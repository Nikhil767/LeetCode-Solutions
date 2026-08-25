public class Solution {
    public int CalPoints(string[] operations) {
        if (operations is null || operations.Length < 1) return 0;
        int total = 0;
        const string C = "C";
        const string D = "D";
        const string PLUS = "+";
        Stack<int> data = new(operations.Length);
        foreach (var item in operations)
        {
            if (item == C)
            {
                var removed = data.Pop();
                total -= removed;
            }
            else if (item == D)
            {
                var newValue = data.Peek() * 2;
                total += newValue;
                data.Push(newValue);
            }
            else if (item == PLUS)
            {
                var prev = data.Pop();
                var prev2 = data.Peek();
                var newValue = prev + prev2;
                total += newValue;
                data.Push(prev);
                data.Push(newValue);
            }
            else
            {
                var currentValue = int.Parse(item);
                total += currentValue;
                data.Push(currentValue);
            }
        }
        return total;
    }
}