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
    public int MaxLevelSum(TreeNode root) {
        if (root == null) return 0;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int level = 1;
        int maxLevel = 1;
        int maxSum = int.MinValue;

        while (queue.Count > 0)
        {
            int size = queue.Count;
            int currentSum = 0;
            for (int i = 0; i < size; i++)
            {
                var node = queue.Dequeue();
                currentSum += node.val;

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                maxLevel = level;
            }
            level++;
        }
        return maxLevel;
    }
}