/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root is null) return null;
        if(root == p || root == q) return root;
        TreeNode leftResult=LowestCommonAncestor(root.left, p, q);
        TreeNode rightResult=LowestCommonAncestor(root.right, p, q);
        if(leftResult != null && rightResult != null)
            return root;
        else if (leftResult != null)
            return leftResult;
        else
            return rightResult;
    }
}