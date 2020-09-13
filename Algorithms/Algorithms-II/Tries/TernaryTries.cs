using System;
using System.Linq;
using System.Collections.Generic;
namespace Tries
{
    class TernaryTries
    {
      private TNode root;
      public void Add(string s, int val)
      {
            Add(ref root, s, val, 0);
      }
      private void Add(ref TNode node, string s, int  val, int index)
      {
        if(index>=s.Length)
          return;
        if(node==null)
        {
          node = new TNode();
          node.ch = s[index];
          if(index==s.Length-1)
          {
            node.val=val;
            return;
          }
          else
          {
              Add(ref node.mid, s, val, index+1);
          }
        }
        else
        {
          if(node.ch>s[index])
          {
            //Console.WriteLine($"Adding {s[index]}");
            Add(ref node.left, s, val, index+1);
          }
          else if(node.ch<s[index])
          {
            Add(ref node.right, s, val, index+1);
          }
          else
          {
            Add(ref node.mid,s, val, index+1);
          }
        }
      }
      public void Print()
      {
        if(root==null)
          return;
        else
          PrintNode(new List<TNode>(){root});
      }
      private void PrintNode(List<TNode> nodes)
      {
        Console.WriteLine($"node list {string.Join<TNode>(',', nodes.ToArray())}");
        var listOfNodes = new List<TNode>();
        foreach(var node in nodes)
        {
          if(node!=null)
          {
           Console.WriteLine($"{node.ch} {node.val}");
          }
          if(node.left!=null)
            listOfNodes.Add(node.left);
          if(node.mid!=null)
            listOfNodes.Add(node.mid);
          if(node.right!=null)
            listOfNodes.Add(node.right);
          PrintNode(listOfNodes);
        }
      }
    }
    public class TNode
    {
      public int? val;
      public  char? ch;
      public TNode left, right, mid;
      public override string ToString()
      {
        return $"{(val==null?"n":val.Value.ToString())}: {(ch==null?"":ch.Value.ToString())}";
      }
    }
}
