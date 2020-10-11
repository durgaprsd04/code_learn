using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class SumRowTree
    {
      public int SumNumbers(TreeNode root)
      {
        if(root==null)
            return 0;
         if(root.left==null && root.right==null)
              return root.val;
        return ((root.left==null)?0:SumNumbersN(root.left, root.val))+( (root.right==null)?0:SumNumbersN(root.right, root.val));
      }
      public int SumNumbersN(TreeNode node, int val1)
      {
        if(node==null)
          return val1;
        var res = val1*10;
          if(node.left==null && node.right==null)
              return res+node.val;
        return  ((node.left==null)?0:SumNumbersN(node.left, res+node.val)) +  ((node.right==null)?0:SumNumbersN(node.right, res+node.val));
      }
    }
}
