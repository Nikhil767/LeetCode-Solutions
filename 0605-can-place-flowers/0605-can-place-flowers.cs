public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
        if(flowerbed is null || flowerbed.Length < 1) return false;
        if(n == 0) return true;
        int counter = n;
        for (int i=0; i<flowerbed.Length; i++)
        {
            if(flowerbed[i] == 0)
            {
                bool leftEmpty = (i == 0) || (flowerbed[i - 1] == 0);
                bool rightEmpty = (i == flowerbed.Length-1) || (flowerbed[i + 1] == 0);
                if(leftEmpty && rightEmpty)
                {
                    counter--;
                    if (counter == 0)
                        return true;
                    i++;
                }                    
            }
        }
        return counter > 0 ? false : true;
    }
}