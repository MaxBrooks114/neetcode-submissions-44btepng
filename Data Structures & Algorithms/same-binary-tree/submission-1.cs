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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        
        if(p == null && q == null )
            return true;

        if((p != null && q == null) || (p == null && q!= null))
            return false;
        var stackP = new Stack<TreeNode>();
        var stackQ  = new Stack<TreeNode>();


        stackP.Push(p);
        stackQ.Push(q);

        while(stackP.Count > 0 && stackQ.Count > 0)
        {
            var currP = stackP.Pop();
            var currQ = stackQ.Pop();

            if(currP.val != currQ.val)
                return false;
            
            if(currP.left != null && currQ.left != null)
            {

                stackP.Push(currP.left);
                stackQ.Push(currQ.left);
            }
            else if(currP.left == null && currQ.left == null)
            {

            }
            else
                return false;
            if(currP.right != null && currQ.right != null)
            {

                stackP.Push(currP.right);
                stackQ.Push(currQ.right);
            }
            else if(currP.right == null && currQ.right == null)
            {

            }
            else
                return false;
          
            
        }


        if(stackP.Count > 0 || stackQ.Count > 0)
            return false;






        return true;
    }
}
