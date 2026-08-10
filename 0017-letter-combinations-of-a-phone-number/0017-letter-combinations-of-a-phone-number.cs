public class Solution {
    public IList<string> LetterCombinations(string digits) {
        List<string> result = new();

        if (string.IsNullOrEmpty(digits))
            return result;

        Dictionary<char, string> map = new()
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };

        Backtrack(0, "", digits, map, result);
        return result;
    }

    private void Backtrack(int index, string current, string digits,
                           Dictionary<char, string> map, List<string> result)
    {
        if (index == digits.Length)
        {
            result.Add(current);
            return;
        }

        string letters = map[digits[index]];

        foreach (char c in letters)
        {
            Backtrack(index + 1, current + c, digits, map, result);
        }
    }
}