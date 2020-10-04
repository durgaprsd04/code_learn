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
      public void InOrderTraverse()
      {
        InOrderTraverse(this);
      }
      private void InOrderTraverse(TreeNode node)
      {
        if(node==null)
        {
          //Console.Write("*");
          return;
        }
        if(node.left !=null)
        {
          InOrderTraverse(node.left);
        }
        else
        {
          Console.Write(node.val);
          return;
        }
        Console.Write(node.val); 
        InOrderTraverse(node.right);
      }
      public void PreOrderTraversal()
      {
          Console.WriteLine();
          PreOrderTraversal(this);
      }
      private void PreOrderTraversal(TreeNode t)
      {
          if(t!=null)
          {
            Console.Write(t.val);
            PreOrderTraversal(t.left);
            PreOrderTraversal(t.right);
          }
            //Console.WriteLine();
      }
      public void PostOrderTraversal()
      {
        Console.WriteLine();
        PostOrderTraversal(this);
        Console.WriteLine();

      }
      private void PostOrderTraversal(TreeNode t)
      {
        if(t!=null)
        {
          PostOrderTraversal(t.left);
          PostOrderTraversal(t.right);
          Console.Write(t.val);
        }
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
  public class TreeUtility
  {
      public TreeNode BuildTreeFromInorder(int [] a)
      {
        if(a.Length <1)
          return null;
        TreeNode t = new TreeNode(a[0],null,null);
        return BuildTreeFromInorder(ref t, a, 1);
     }
      private TreeNode BuildTreeFromInorder(ref TreeNode t, int []a,int i)
      {
        var len = a.Length;
        if(i>=len)
          return t;
        if(t.left==null && t.right==null)
          t = new TreeNode(a[1],t, null);
        else if(t.left!=null && t.right ==null)
          t.right = new TreeNode(a[i], null,null);
        else if(t.left!=null && t.right!=null)
          t= new TreeNode(a[i], t, null);
        return BuildTreeFromInorder(ref t, a, i+1);
      }
    public  TreeNode ConstructTreeFromArray(int? [] a)
    {
       int i=1;
        if(a.Length <=1)
          return null;
        TreeNode node = new TreeNode(a[1]??0, null, null);
       node.left =  ConstructTreeFromArray1(ref node.left, a, 2*i);
       node.right = ConstructTreeFromArray1(ref node.right, a, 2*i+1);
       return node;
    }
    public TreeNode ConstructTreeFromArray1(ref TreeNode t, int? [] a, int i)
    {
      var len = a.Length;
      if(i>=len)
        return t;
      if(t==null)
        if(a[i]==null)
          t = null;
        else
          t = new TreeNode(a[i].Value,null,null);
      if(t!=null)
      {
       t.left =  ConstructTreeFromArray1(ref t.left, a, 2*i);
       t.right = ConstructTreeFromArray1(ref t.right, a, 2*i+1);
      }
      Console.WriteLine($"a[{i}] {a[i]}");
      return t;
    }

  }

}
