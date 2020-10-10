using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class CorrespondingNodeClass
    {
      public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
      {
        var levelOrderPos = GetPlaceInLevelOrder(original, target, 1);
        Console.WriteLine($" n {levelOrderPos}");
        return DoLevelOrderForN(cloned, levelOrderPos,1);
      }
      public int GetPlaceInLevelOrder(TreeNode node, TreeNode target, int n)
      {
        if(node==null)
          return 0;
        if(node==target)
          return n;
        else
        {
          return GetPlaceInLevelOrder(node.left, target, 2*n) + GetPlaceInLevelOrder(node.right, target, 2*n+1) ;
        }
      }
      public TreeNode DoLevelOrderForN(TreeNode node, int n, int k)
      {
          if(node==null)
            return null;
          if(n<k)
            return null;
          if(n==k)
            return node;
          else
          {
            var v1= DoLevelOrderForN(node.left, n, 2*k);
            var v2 = DoLevelOrderForN(node.right, n,  2*k+1);
            return v1==null? v2:v1;
          }
      }
    }
}
