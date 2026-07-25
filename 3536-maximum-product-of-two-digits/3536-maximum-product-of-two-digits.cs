public class Solution {
    public int MaxProduct(int n) {
        int firstMax=0;
        int secondMax=0;
        while(n>0)
        {
            var r = n%10;
            n = n/10;
            if (firstMax < r)
            {
                secondMax = firstMax;
                firstMax = r;
            }                
            else if(secondMax < r)
                secondMax = r;
        }
        return firstMax*secondMax;
    }
}