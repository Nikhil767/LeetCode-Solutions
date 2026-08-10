public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;                       // minimum possible speed
        int right = piles.Max();            // maximum possible speed

        while (left < right)
        {
            int mid = left + ((right - left) >> 1);// candidate speed k
            //int mid = left + (right - left) / 2;   // candidate speed k
            if (CanFinish(piles, h, mid))
            {
                right = mid;                // try smaller k
            }
            else
            {
                left = mid + 1;             // need faster speed
            }
        }

        return left;                        // minimum valid k
    }

    private bool CanFinish(int[] piles, int h, int k)
    {
        int hours = 0;
        foreach (int pile in piles)
        {
            // hours needed for this pile = ceil(pile / k)
            hours += (pile + k - 1) / k;   // faster ceil trick
            if(hours > h) return false;    // early exit
        }
        return hours <= h;
    }
}