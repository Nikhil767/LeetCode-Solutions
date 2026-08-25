public class Solution {
    public int CalPoints(string[] operations) {
        if (operations is null || operations.Length < 1) return 0;
        int total = 0;
        const string C = "C";
        const string D = "D";
        const string PLUS = "+";
        Stack<string> data = new(operations.Length);
        foreach (var item in operations)
        {
            if (item == C)            
                data.Pop();            
            else if (item == D)
            {
                var prev = data.Peek();
                int newValue = int.Parse(prev) * 2;
                data.Push(newValue.ToString());
            }
            else if (item == PLUS)
            {
                var prev = data.Pop();
                var prev2 = data.Peek();
                int newValue = int.Parse(prev) + int.Parse(prev2);
                data.Push(prev);
                data.Push(newValue.ToString());
            }
            else
                data.Push(item);				
        }
        if(data.Count > 0)
        {
            foreach (var item in data)            
                total += int.Parse(item);            
        }
        return total;
    }
}