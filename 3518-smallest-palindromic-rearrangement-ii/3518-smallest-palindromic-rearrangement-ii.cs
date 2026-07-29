public class Solution {
    public string SmallestPalindrome(string s, int k) {
        if (string.IsNullOrEmpty(s)) return s;
        if (s.Length == 1) return k == 1 ? s : "";

        int[] freq = new int[26];
        foreach (var c in s)        
            freq[c - 'a']++;

        char? middleChar = null;
        int[] halfFreq = new int[26];
        int halfLength = 0;

        // 1. Verify palindrome validity & build half-frequency array
        for (int i = 0; i < 26; i++)
        {
            if ((freq[i] & 1) == 1)
            {
                if (middleChar != null) return ""; // More than 1 odd char -> impossible
                middleChar = (char)('a' + i);
            }
            halfFreq[i] = freq[i] / 2;
            halfLength += halfFreq[i];
        }

        // 2. Check if total possible permutations is less than k
        long totalPerms = CountPermutations(halfFreq, halfLength, k);
        if (totalPerms < k) return "";

        // 3. Build the first half position-by-position using combinatorics
        StringBuilder sb = new StringBuilder(s.Length);
        long remainingK = k;

        for (int pos = 0; pos < halfLength; pos++)
        {
            int remainingLength = halfLength - 1 - pos;

            for (int i = 0; i < 26; i++)
            {
                if (halfFreq[i] == 0) continue;

                // Pretend to place character 'a' + i
                halfFreq[i]--;

                // Count how many valid permutations can be formed with the remaining characters
                long perms = CountPermutations(halfFreq, remainingLength, remainingK);

                if (remainingK <= perms)
                {
                    // The k-th permutation starts with this character at position 'pos'
                    sb.Append((char)('a' + i));
                    break; // Lock in character and move to next position
                }
                else
                {
                    // k-th permutation is further ahead; skip these permutations
                    remainingK -= perms;
                    halfFreq[i]++; // Backtrack and try next character
                }
            }
        }

        // 4. Assemble the full palindrome (First Half + Middle + Reversed First Half)
        string firstHalf = sb.ToString();
        if (middleChar.HasValue)
            sb.Append(middleChar.Value);

        for (int i = firstHalf.Length - 1; i >= 0; i--)        
            sb.Append(firstHalf[i]);        

        return sb.ToString();
    }

    // Helper: Calculates N! / (c1! * c2! * ... * c26!) safely without overflow
    private long CountPermutations(int[] counts, int totalLength, long limit)
    {
        if (totalLength == 0) return 1;

        long ans = 1;
        int currentLen = 1;

        for (int i = 0; i < 26; i++)
        {
            int count = counts[i];
            for (int j = 1; j <= count; j++)
            {
                ans = ans * currentLen / j;
                currentLen++;

                // Cap at limit (or max long) to prevent integer overflow
                if (ans >= limit) return limit;
            }
        }

        return ans;
    }
}