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
       
        var maxDepth = 0;

        maxDepth = Math.Max(Traverse(root.left, 1), Traverse(root.right, 1));


        return maxDepth;
    }


    private int Traverse(TreeNode node, int depth)
    {
        if(node == null)
            return depth;
        var maxDepth = 0;
        depth+=1;
        if(node.left != null)
            maxDepth = Math.Max(Traverse(node.left, depth), maxDepth);
        if(node.right != null)
             maxDepth = Math.Max(Traverse(node.right, depth), maxDepth);
    
        return Math.Max(depth, maxDepth);
    }
}
