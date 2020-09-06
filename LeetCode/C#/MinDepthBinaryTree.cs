using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class MinDepthBinaryTreeClass
    {
      public int MinDepth(TreeNode root)
      {
            if(root==null)
              return 0;
            if(root.left==null && root.right==null)
              return 1;
            var left= 1+MinDepth(root.left);
            var right = 1+ MinDepth(root.right);
            if(root.right!=null && root.left!=null)
                return left<right?left:right;
            else
            {
                if(root.right==null)
                    return left;
                else
                    return right;
            }
      }
    }
}
