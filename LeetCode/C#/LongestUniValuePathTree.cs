using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class LongestUniValuePathTree
    {
      public int LongestUnivaluePath(TreeNode root)
      {
         int count=0;
          if(root==null)
            return 0;
          if(root.left==null && root.right==null)
            return 0;
          if(root?.left?.val==root.val)
            count++;
          if(root?.right?.val==root.val)
            count++;
          if(root?.left?.val ==root?.right?.val && root?.right?.val == root?.val)
            count+= 3;
          return LongestUniValuePath1(root?.left, count)+  LongestUniValuePath1(root?.right, count);
      }
     public int LongestUniValuePath1(TreeNode root,int count)
     {
          if(root==null)
            return count;
          Console.WriteLine($"root.val {root.val} count {count} ");
          if(root.left==null && root.right==null)
            return count;
          if(root?.left?.val != root.val || root?.right?.val !=root.val)
            count=0;
         if(root?.left?.val==root.val)
            count++;
          if(root?.right?.val==root.val)
            count++;
          if(root?.left?.val ==root?.right?.val && root?.right?.val == root?.val)
            count+= 3;
          return LongestUniValuePath1(root.left, count) +  LongestUniValuePath1(root.right, count);
     }
    }
}

