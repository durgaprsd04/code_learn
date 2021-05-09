using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
   
    public class PostPreTreeConstruction
    { 
        private readonly  int index=0;
        public TreeNode ConstructFromPrePost(int[] pre, int[] post) {
        
        return ConstructFromPrePost1(pre, post, pre.Length-1);
    }
    private TreeNode ConstructFromPrePost1(int [] pre, int [] post, int limit)
    {
        //Console.WriteLine($" index  {Array.IndexOf(post, pre[index])} limit {limit}");
        if(Array.IndexOf(post, pre[index])>limit)
        {
            //index--;
            return null;
        }
        var tree =   new TreeNode(pre[index++]);
        tree.left = ConstructFromPrePost(pre, post, Array.IndexOf(post, pre[index]));
        tree.right = ConstructFromPrePost(pre, post, Array.IndexOf(post, pre[index]));
        return tree;
    }
    }
}