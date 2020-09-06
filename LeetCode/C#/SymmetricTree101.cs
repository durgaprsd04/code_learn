using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class SymmetricTreeClass
    {
      public bool IsSymmetric(TreeNode root)
      {
            if(root==null)
              return true;
            return IsSameTree(root.left, root.right);
      }
      public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p==null && q==null)
          return true;
        if(p==null)
          return false;
        if(q==null)
          return false;
       if(p.val==q.val)
        {
          return IsSameTree(p.left,q.left) && IsSameTree(p.right, q.right);
        }
        else
          return false;
    }
    }
}
