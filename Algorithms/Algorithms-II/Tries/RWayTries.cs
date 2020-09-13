using System;
using System.Collections.Generic;
namespace Tries
{
    class RWayTries
    {
      private const int ALimit=97;
      private Node root;
      //Dictionary<int,Dictionary<int,Node>> lvl = new Dictionary<int, Dictionary<int,Node>>();
      //26 RWay trie small letters starts with a(97).
      public void Add(string value, int key)
      {
          Add(ref root, value, key, 0);
      }
      private void Add(ref Node nod, string value, int n,int len )
      {
        if(nod==null)
          nod = new Node(null);
        char c='a';
        int index;
        if(len< value.Length)
          c = value[len];
        index  = (int)c-ALimit;
        if(nod.nodeList[index]==null)
        {
          //Console.WriteLine("hre");
            if(len==value.Length-1)
            {
              nod.nodeList[index] = new Node(n);
              return;
            }
            else
            {
              nod.nodeList[index] = new Node(null);
              Add(ref nod.nodeList[index], value,n, len+1);
            }
        }
        else
        {
            if(len==value.Length-1)
            {
              nod.nodeList[index].val = n;
              return;
            }
            else
              Add(ref nod.nodeList[index], value, n, len+1);
        }
      }
      public int?  Get(string searchKey)
      {
        return Get(root, searchKey, 0);
      }
      private int? Get(Node node, string searchKey, int i)
      {
          if(node==null)
            return null;
          if(i>= searchKey.Length)
            return null;
          if(node.nodeList[(int)(searchKey[i]- ALimit )]==null)
            return null;
          else
          {
            //search hit
            if(i==(searchKey.Length-1))
              return node.nodeList[(int)(searchKey[i] -ALimit)].val;
            else
              return Get(node.nodeList[(int)(searchKey[i] -ALimit)], searchKey, i+1);
          }

      }
      public void Delete(string searchKey)
      {
        root = Delete(root,searchKey, 0);
      }
      public Node Delete(Node node, string searchKey, int i)
      {
          if(node==null)
            return null;
          if(i>= searchKey.Length)
            return node;
          if(node.nodeList[(int)(searchKey[i]- ALimit )]==null)
            return node;
          else
          {
            //all delete during search hit
            if(i==(searchKey.Length-1))
            {
              if(node.nodeList[(int)(searchKey[i] -ALimit)].val!=null)
              {
                Console.WriteLine($"Value detected to be {(int)(searchKey[i] -ALimit)}");
                if(checkIfNoChildren(node.nodeList[ (int)(searchKey[i] -ALimit)], -1)||checkIfNoChildren(node, (int)(searchKey[i] -ALimit))|| node.val!=null)
                {
                  Console.WriteLine($"Value detected in node.val {node.val}");
                  return node;
                }
                else
                {
                  Console.WriteLine("null returned");
                  return null;
                }
              }
              return node;
            }
            else
            {
                var result = Delete(node.nodeList[(int)(searchKey[i] -ALimit)], searchKey, i+1);
                if(result==null)
                {
                  Console.WriteLine($"Post null recieval  {(char)(searchKey[i])} ");
                  node.nodeList[(int)(searchKey[i] -ALimit)]=null;
                  if(checkIfNoChildren(node, (int)(searchKey[i] -ALimit))|| node.val!=null)
                  {
                    //PrintNode(node, -1,0);
                    return node;
                  }
                  else
                    return null;
                }
                else
                {
                  node.nodeList[(int)(searchKey[i] -ALimit)] = result;
                  return node;
                }
            }
          }
      }
      private bool checkIfNoChildren(Node node, int index)
      {
        //Console.WriteLine($"chdcking if {node.val} is null");
        bool hasNonNull = false;
        for(int j =0;j<node.nodeList.Length;j++)
        {
          //Console.Write($" {node.nodeList[j]?.val}");
           if(node.nodeList[j]!=null && j!=index)
           {
              hasNonNull=true;
              break;
           }
        }
       return hasNonNull;
      }
      public void Print()
      {
        if(root!=null)
          PrintNode(root, -1, 0);
      }
      private void PrintNode(Node node, int i, int level)
      {
          if(node ==null)
            return;
          else
          {
            Console.Write($"[{(char)(i+97) }:{node.val} l:{level}] ");
            int i1=0;
            foreach(var nod in node.nodeList)
            {
              PrintNode(nod, i1, level+1);
              i1++;
            }
          }
      }

    }
    public class Node
    {
      public int? val ;
      public Node [] nodeList;
      public Node(int? val)
      {
          this.val=val;
          nodeList = new Node[26];
      }
    }
}
