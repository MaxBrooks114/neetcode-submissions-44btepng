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
    public TreeNode InvertTree(TreeNode root) {
        

        InvertNode(root);

        return root;



    }


    private void InvertNode(TreeNode node)
    {

        if(node == null)
            return;
        var temp = node.left;
        node.left = node.right;
        node.right = temp;

        if(node.left != null)
            InvertNode(node.left);
        if(node.right != null)
            InvertNode(node.right);

        
    }
}
