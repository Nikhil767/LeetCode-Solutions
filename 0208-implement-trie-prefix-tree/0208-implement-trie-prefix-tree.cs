public class Trie {
    private Node _node;
    public Trie() {
        _node = new Node();
    }
    
    public void Insert(string word) {
        if(string.IsNullOrEmpty(word)) return;
        Node current = _node;
        for (int i=0; i<word.Length; i++)
        {
            int index = word[i] - 'a';
            if (current.children[index] == null)            
                current.children[index] = new Node();            
            current = current.children[index];
        }
        current.isEndOfWord=true;
    }
    
    public bool Search(string word) {
        if(string.IsNullOrEmpty(word)) return false;
        Node current = _node;
        foreach(var c in word)
        {
            int index = c - 'a';
            if (current.children[index] == null)
                return false;
            current = current.children[index];
        }
        return current.isEndOfWord==true;
    }
    
    public bool StartsWith(string prefix) {
        if(string.IsNullOrEmpty(prefix)) return false;
        Node current = _node;
        foreach(var c in prefix)
        {
            int index = c - 'a';
            if (current.children[index] == null)
                return false;
            current = current.children[index];
        }
        return true;
    }
}

public class Node
{
    public Node[] children = new Node[26];
    public bool isEndOfWord = false;
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */