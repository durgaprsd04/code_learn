using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{

  class AddRowToTreeClass
  {
     public TreeNode AddOneRow(TreeNode root, int v, int d) {
        if(d!=1)
            return AddOneRow1(root, v, d, 1);
        else
        {
            var node1 = new TreeNode(v, root, null);
            return node1;
        }
    }
    public TreeNode AddOneRow1(TreeNode node, int v, int d, int currd)
    {
        if(node==null)
            return null;
      if(currd>d)
        return null;
      if((d-1)==currd)
      {
          var leftNode = new TreeNode(v, node.left,null);
          var rightNode = new TreeNode(v, null, node.right);
          node.left = leftNode;
          node.right=rightNode;
      }
      else
      {
        node.left = AddOneRow1(node.left, v, d,currd +1);
        node.right = AddOneRow1(node.right,v, d, currd+1);
      }
      return node;
    }
  }
}

