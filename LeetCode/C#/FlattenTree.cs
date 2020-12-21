using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    public class FlattenTree
    {
        public void Flatten(TreeNode root) 
        {
        if(root!=null)
            root = FlattenNode( root.left , root);
        
        }
        public TreeNode FlattenNode( TreeNode left,  TreeNode node)
        {
            if(left==null)
                return node;
            if(node==null)
                return null;
            
            left = FlattenNode( left.left, left);
            if(left.left==null)
            {
                if(left.right==null)
                    {
                        Console.WriteLine("here now");
                        var temp = node.right;
                        node.right = left;
                        if(temp!=null)
                            left.right = FlattenNode(temp.left, temp);
                        else 
                            left.right=null;
                        node.left=null;
                    }
                    else
                    {
                        var temp = node.right;
                        node.right = left;
                        var last = left.right;
                        while(last.right!=null)
                            last = last.right;
                        if(temp!=null)
                            last.right = FlattenNode(temp.left, temp);
                        else
                            last.right=null;
                        node.left=null;
                    }
            }
            return  node;
                
        }
    }
}