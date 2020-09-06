using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
      public void Add(TreeNode node)
      {
         if(val<node.val)
          Add(ref this.right,node);
         else
          Add(ref this.left, node);
      }
      public void  Add(ref TreeNode node, TreeNode node1)
      {
        if(node==null)
        {
          node=  new TreeNode(node1.val,null,null);
          return;
        }
        if(node.val<node1.val)
        {
            Console.WriteLine($"adding  {node1.val} to  {node.val} right");
            Add(ref node.right, node1);
        }
        else
        {
              Console.WriteLine($"adding {node1.val} to {node.val} left");
            Add(ref node.left,node1);
        }
      }
      public override string  ToString()
      {
        return val.ToString();
      }
      public void Traverse()
      {
        Console.Write(this.val);
        Traverse(this.left);
        Traverse(this.right);
        Console.WriteLine();
      }
      public void Traverse(TreeNode node)
      {
        if(node==null)
          return;
        Console.Write(node.val);
        if(node.left==null &&  node.right==null)
        {
          //Console.WriteLine();
          return;
        }
        if(node.left!=null)
            Traverse(node.left);
        if(node.right!=null)
          Traverse(node.right);
      }
  }

}
