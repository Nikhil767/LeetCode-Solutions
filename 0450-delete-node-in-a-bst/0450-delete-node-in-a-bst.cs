/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode DeleteNode(TreeNode root, int key) {
        	return SearchDeleteNodeBST(root, key);
        }

        private static TreeNode SearchDeleteNodeBST(TreeNode root, int val)
{
	if (root is null) return null;
	if (val == root.val)
	{
		// Case 1 & 2: 0 or 1 child
		if (root.left is null) return root.right;
		if (root.right is null) return root.left;

		// Case 3: 2 children
		// Find min node in right subtree (inorder successor)
		TreeNode successor = GetMin(root.right);
		root.val = successor.val; // Copy value
		root.right = SearchDeleteNodeBST(root.right, successor.val); // Delete successor
	}
	else if (val < root.val)			
		root.left = SearchDeleteNodeBST(root.left, val);			
	else if (val > root.val)			
		root.right = SearchDeleteNodeBST(root.right, val);			
	return root;
}

private static TreeNode GetMin(TreeNode node)
{
	while (node.left is not null)
		node = node.left;
	return node;
}
}