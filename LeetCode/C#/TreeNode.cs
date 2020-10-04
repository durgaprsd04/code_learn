using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode
{
    public class TreeNode {
      public int  val;
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
        //Console.WriteLine();
        Traverse(this.left);
        Traverse(this.right);
        Console.WriteLine();
      }
      public void Traverse(TreeNode node)
      {
        if(node==null)
        {
          //Console.Write("*");
          return;
        }
        Console.Write(node.val);
        //Console.WriteLine();
        Traverse(node.left);
        Traverse(node.right);
      }
      public void AddFromLevelOrderArray(int? [] a)
      {
        //add zero to a[0] index starts from 1
        if(a.Length<2)
          return;
        if(this.val==0)
          this.val = a[1]??0;
        AddFromLevelOrder1(ref this.left, a,2);
        AddFromLevelOrder1(ref this.right, a,3);
      }
      public void AddFromLevelOrder1(ref TreeNode node, int?[] a, int i  )
      {
        if( i< a.Length)
        {
          //Console.WriteLine($"a [{i}]  {a[i]}");
          if(a[i]!=null)
          {
            if(node==null)
              node = new TreeNode( a[i]??0,null,null);
            else
              node.val = a[i]??0;
            AddFromLevelOrder1(ref node.left, a, 2*i);
            AddFromLevelOrder1(ref node.right, a,2*i+1);
          }
        }
      }
  }

}
