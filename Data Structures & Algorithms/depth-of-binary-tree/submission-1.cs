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
    public int MaxDepth(TreeNode root) {
        if(root == null)
            return 0;
        var depth = 1;
        var maxDepth = 0;
        var stack = new Queue<(TreeNode node, int depth)>();
        stack.Enqueue((root, 1));

        while(stack.Count > 0)
        {
            var curr = stack.Dequeue();
            maxDepth = Math.Max(curr.depth, maxDepth);
            if(curr.node.left != null)
                stack.Enqueue((curr.node.left, curr.depth +1));
            if(curr.node.right != null)
                stack.Enqueue((curr.node.right, curr.depth +1));
        }



        return maxDepth;
    }
}
