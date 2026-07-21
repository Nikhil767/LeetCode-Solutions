public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        int n = asteroids.Length;
        Stack<int> data = new(n);
        for (int start=0; start<n; start++)
        {            
            bool alive = true;
            var current = asteroids[start];
            while (alive && data.Count > 0 && data.Peek() > 0 && current < 0)
            {
                var topAbs = Math.Abs(data.Peek());
                var currentAbs = Math.Abs(current);
                if (topAbs < currentAbs)
                    data.Pop();
                else if (topAbs == currentAbs)
                {
                    data.Pop();
                    alive = false;
                }
                else if (topAbs > currentAbs)                
                    alive = false;                
            }
            if(alive)
                data.Push(current);
        }
        var count = data.Count-1;
        int[] result = new int[count+1];
        for (int i=count; i>=0; i--)
        {
            result[i] = data.Pop();
        }
        return result;
    }
}