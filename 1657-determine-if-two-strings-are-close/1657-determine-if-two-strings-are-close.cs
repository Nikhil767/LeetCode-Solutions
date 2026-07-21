public class Solution {
    public bool CloseStrings(string word1, string word2) {
        if(string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2)) return false;
        if(word1.Length != word2.Length) return false;
        var span1 = word1.AsSpan();
        var span2 = word2.AsSpan();
        int[] freq1 = new int[26];
        int[] freq2 = new int[26];
        for (int i=0; i<span1.Length; i++)
        {
            freq1[span1[i] - 'a']++;
            freq2[span2[i] - 'a']++;
        }
        for (int j=0; j<freq1.Length;j++)
        {
            var has1Value = freq1[j] > 0;
            var has2Value = freq2[j] > 0;
            if(has1Value != has2Value)
                return false;
        }
        Array.Sort(freq1); // Compare frequency distributions
        Array.Sort(freq2);
        for (int i = 0; i < 26; i++)
        {
            if (freq1[i] != freq2[i])
                return false;
        }
        return true;
    }
}