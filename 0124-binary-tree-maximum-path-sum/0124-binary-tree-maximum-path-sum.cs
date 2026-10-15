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
    
    int maxSum = int.MinValue;

    public int MaxPathSum(TreeNode root) {
        DFS(root);
        return maxSum;
    }

    private int DFS(TreeNode node)
    {
        if (node == null) return 0;

        // Compute max path on left and right — ignore negatives
        int left = Math.Max(0, DFS(node.left));
        int right = Math.Max(0, DFS(node.right));

        // Path THROUGH the node (can take both sides)
        int throughNode = node.val + left + right;

        // Update global max
        maxSum = Math.Max(maxSum, throughNode);

        // Return best single-branch path upward
        return node.val + Math.Max(left, right);
    }
}