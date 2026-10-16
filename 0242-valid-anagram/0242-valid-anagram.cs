public class Solution {
    public bool IsAnagram(string s, string t) {
        
        bool result = false;
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return result;
        if(s.Length != t.Length) return result;

        return IsAnagramByFrequencyArray(s,t);
        //return IsAnagramByXOR(s,t);
    }

    public bool IsAnagramByXOR(string s, string t) {
        // XOR accumulator. If all characters cancel out perfectly, xor will end as 0.
        int xor = 0;

        // Iterate through both strings (assuming same length).
        // XOR each character from s and t.
        // Because XOR has the property: a ^ a = 0 and a ^ b ^ a ^ b = 0,
        // matching pairs cancel out.
        for (int i = 0; i < s.Length; i++)
        {
            xor ^= s[i];// Apply XOR with character from s
            xor ^= t[i];// Apply XOR with character from t
        }
        // If xor == 0, it means all characters cancelled out.
        // HOWEVER: this does NOT guarantee the strings are anagrams.
        // Different multisets can also cancel out (e.g., "aa" vs "bb").
        return xor == 0;
    }

    public bool IsAnagramByFrequencyArray(string s, string t) {
        int[] count= new int[26];        
        for(int i=0; i<s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }        
        for(int j=0; j<count.Length; j++)
        {
            if(count[j] != 0)
                return false;
        }
        return true; 
    }
}