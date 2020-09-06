using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class PathSumBST
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            return HasPathSum(root, sum, 0);
        }
        public bool HasPathSum(TreeNode node, int sum , int expSum)
        {
          if(node==null)
          {
            return false;
          }
          if(node.left==null && node.right ==null)
          {
            Console.WriteLine($"node.val {node.val}, sum {expSum+node.val}");
            return sum == (expSum+ node.val);
          }
          return HasPathSum( node.left, sum, expSum+node.val) || HasPathSum(node.right, sum, expSum +node.val);
        }
    }
}
