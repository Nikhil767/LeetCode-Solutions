public class Solution {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        if(products is null || products.Length < 1 || string.IsNullOrWhiteSpace(searchWord)) return null;
        Array.Sort(products); 
        TrieNode root = new TrieNode();        
        // Build Trie
        foreach (var product in products)
        {
            TrieNode current = root;
            foreach (char c in product)
            {
                int index = c - 'a';
                if (current.children[index] == null)
                    current.children[index] = new TrieNode();

                // Add product to suggestion list (keep only 3 smallest)
                if (current.children[index].suggestions.Count < 3)
                    current.children[index].suggestions.Add(product);

                current = current.children[index];
            }
        }

        // Search suggestions for each prefix
        IList<IList<string>> result = new List<IList<string>>();
        TrieNode node = root;
        foreach (char c in searchWord)
        {
            int index = c - 'a';
            if (node != null)
                node = node.children[index];
            // If node is null, no more matches → add empty list
            result.Add(node == null ? [] : node.suggestions);
        }
        return result;
    }

    public class TrieNode
    {
        public TrieNode[] children = new TrieNode[26];
        public List<string> suggestions = new(3);
    }
}