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
    public int LongestZigZag(TreeNode root) {
        	int max = 0;
            MaxZigZag(root, ref max);
            return max;
    }

    private static (int leftZig, int rightZig) MaxZigZag(TreeNode node, ref int max)
    {
        if (node == null)
            return (-1, -1);
        var left = MaxZigZag(node.left, ref max);
        var right = MaxZigZag(node.right, ref max);
        int leftZig = 1 + left.rightZig;   // go left → next must go right
        int rightZig = 1 + right.leftZig;  // go right → next must go left
        max = Math.Max(max, Math.Max(leftZig, rightZig));
        return (leftZig, rightZig);
    }
}