public class Solution {
    public int LargestAltitude(int[] gain) {
        int maxAltitude=0;
        int currentAltitude=0;
        for (int i = 0; i < gain.Length; i++) 
        {
            currentAltitude += gain[i];
            maxAltitude = Math.Max(maxAltitude, currentAltitude);
        }
        return maxAltitude;
    }
}