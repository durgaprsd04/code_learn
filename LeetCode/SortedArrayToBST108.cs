using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    class SortedArrayToBSTClass
    {
      public TreeNode SortedArrayToBST(int[] nums)
      {
          var len = nums.Length-1;
          var hi =len;
          var lo =0;
          List<int> listOfindex  = GetAllPoints(hi,lo);
          TreeNode res=null;
          if(hi<lo)
            return res;
          foreach(var v in listOfindex)
          {
              Add(ref res, new TreeNode(nums[v],null,null));
          }
          Console.WriteLine("index array "+string.Join(',',listOfindex.ToArray()));
          return res;
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

      public List<int> GetAllPoints(int hi, int lo)
      {
        Console.WriteLine($"hi {hi} lo {lo}");
        var mid = (hi+lo)/2;
        List<int> finalList;
        if(hi==lo)
          return new List<int>{hi};
        if(hi-lo>=2)
        {
          Console.WriteLine($"hi {hi} lo {lo} mid {mid}");
          finalList  = new List<int>{mid};
        }
        else
          finalList = new List<int>{lo,hi};

        List<int> v1 = new List<int>();
        List<int> v2 = new List<int>();
        if((hi-lo)>=2)
        {
          v1 = GetAllPoints(mid,lo);
          v2 = GetAllPoints(hi,mid+1);
        }
        foreach(var v in v1)
          if(!finalList.Contains(v))
            finalList.Add(v);
        foreach(var v in v2)
          if(!finalList.Contains(v))
            finalList.Add(v);
        return finalList;
      }
    }
}
