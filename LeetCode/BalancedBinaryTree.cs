using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class BalancedBinaryTree
    {

      public bool IsBalanced(TreeNode root)
      {
            if(root==null)
              return true;
            else if(root.left==null && root.right==null)
              return true;
            else if(root.left==null && MaxDepth(root.right)<=1)
              return true;
            else if(root.right==null && MaxDepth(root.left)<=1)
              return true;
            else if(root.right!=null && root.left !=null)
              return (IsBalanced(root.left) && IsBalanced(root.right) && (Math.Abs(MaxDepth(root.left)-MaxDepth(root.right))<=1));
            else return false;
      }
       public int MaxDepth(TreeNode root)
        {
            if(root==null)
              return 0;
             var mleft =  1+ MaxDepth(root.left);
             var mright = 1+ MaxDepth(root.right);
             return  ((mleft>mright)?mleft:mright);
        }
    }
}
