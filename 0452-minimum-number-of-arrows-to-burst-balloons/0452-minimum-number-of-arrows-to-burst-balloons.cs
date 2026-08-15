public class Solution {
    public int FindMinArrowShots(int[][] points) {
        if (points.Length == 0)
        return 0;

        // Sort by end coordinate
        Array.Sort(points, (a, b) => a[1].CompareTo(b[1]));
        //SelectionSort(points);

        int arrows = 1;
        int lastEnd = points[0][1];
        for (int i = 1; i < points.Length; i++)
        {
            // If current balloon starts after lastEnd, we need a new arrow
            if (points[i][0] > lastEnd)
            {
                arrows++;
                lastEnd = points[i][1];
            }
        }
        return arrows;
    }

    private void SelectionSort(int[][] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j][1] < arr[minIndex][1])
                    minIndex = j;
            }
            var temp = arr[i];
            arr[i] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }
}