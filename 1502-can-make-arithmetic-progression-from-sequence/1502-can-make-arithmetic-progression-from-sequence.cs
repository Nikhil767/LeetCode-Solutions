public class Solution {
    public bool CanMakeArithmeticProgression(int[] arr) {
        Array.Sort(arr);
        int diff = arr[1] - arr[0];;
        for (int i = 2; i < arr.Length; i++)
        {
            int currDiff = arr[i] - arr[i - 1];
            if (currDiff != diff)
                return false;
        }
        return true;
    }
}