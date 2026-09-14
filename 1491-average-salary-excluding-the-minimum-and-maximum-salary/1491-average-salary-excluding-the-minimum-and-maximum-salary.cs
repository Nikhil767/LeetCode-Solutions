public class Solution {
    public double Average(int[] salary) {
        // Step 1: Find minimum and maximum salary
        int min = int.MaxValue;
        int max = int.MinValue;
        foreach (int s in salary)
        {
            if (s < min)
                min = s;

            if (s > max)
                max = s;
        }

        // Step 2: Compute total sum of all salaries
        int total = 0;
        foreach (int s in salary)
        {
            total += s;
        }

        // Step 3: Remove min and max from total
        int sumWithoutMinMax = total - min - max;

        // Step 4: Count of remaining employees
        int count = salary.Length - 2;

        // Step 5: Compute average
        double average = (double)sumWithoutMinMax / count;

        return average;
    }
}