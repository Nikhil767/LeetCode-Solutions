public class Solution {
    public string MergeAlternately(string word1, string word2) {        
        var hasWord1 = !string.IsNullOrWhiteSpace(word1);
        var hasWord2 = !string.IsNullOrWhiteSpace(word2);
        if(hasWord1 && !hasWord2)
            return word1;
        if(!hasWord1 && hasWord2)
            return word2;
        StringBuilder sb = new(word1.Length+word2.Length);
        int safeIndex = Math.Min(word1.Length, word2.Length);
        for(int i=0; i<safeIndex; i++)
        {
            sb.Append(word1[i]);
            sb.Append(word2[i]);
        }
        if(word1.Length > safeIndex)
            sb.Append(word1.AsSpan(safeIndex));
        else if(word2.Length > safeIndex)
            sb.Append(word2.AsSpan(safeIndex));        
        return sb.ToString();
    }
}