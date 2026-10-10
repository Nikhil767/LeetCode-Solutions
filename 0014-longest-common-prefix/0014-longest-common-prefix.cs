public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs is null || strs.Length < 1) return "";

        return VerticalScanning(strs);        
    }

    public string VerticalScanning(string[] strs)
    {
        string first = strs[0];
        StringBuilder sb = new(strs.Length * 2);
        for (int i = 0; i < first.Length; i++)
        {
            char ch = first[i];
            foreach (var s in strs)
            {
                if (i == s.Length || s[i] != ch)
                    return first.Substring(0, i);
            }
        }
        return first;
    }

    public string HorizontalScanning(string[] strs)
    {
        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "")
                    return "";
            }
        }
        return prefix;
    }
}