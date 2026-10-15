public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        var result = new List<string>();
    int i = 0;
    int n = words.Length;

    while (i < n)
    {
        int lineLen = words[i].Length;
        int j = i + 1;

        // Greedily fit as many words as possible
        while (j < n && lineLen + 1 + words[j].Length <= maxWidth)
        {
            lineLen += 1 + words[j].Length;
            j++;
        }

        int gaps = j - i - 1;
        var sb = new StringBuilder();

        // Case 1: Last line OR only one word → left-justified
        if (j == n || gaps == 0)
        {
            for (int k = i; k < j; k++)
            {
                sb.Append(words[k]);
                if (k < j - 1)
                    sb.Append(' ');
            }

            // Fill remaining spaces
            int remaining = maxWidth - sb.Length;
            sb.Append(' ', remaining);
        }
        else
        {
            // Case 2: Fully justified line
            int totalSpaces = maxWidth - (lineLen - gaps); // subtract word lengths
            int spacePerGap = totalSpaces / gaps;
            int extraSpaces = totalSpaces % gaps; // leftmost gaps get more

            for (int k = i; k < j; k++)
            {
                sb.Append(words[k]);

                if (k < j - 1)
                {
                    int spaces = spacePerGap + (extraSpaces-- > 0 ? 1 : 0);
                    sb.Append(' ', spaces);
                }
            }
        }

        result.Add(sb.ToString());
        i = j;
    }

    return result;
    }
}