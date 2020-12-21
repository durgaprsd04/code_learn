using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode
{
    public class InvertBinaryTree
    { 
        public TreeNode InvertTree(TreeNode root) 
        {
            root = InvertTree1(root);
            return root;
        }
        public TreeNode InvertTree1(TreeNode root)
        {
            if(root==null)
                return null;
            if(root.left!=null || root.right!=null)
            {
                root.left = InvertTree1(root.left);
                root.right = InvertTree1(root.right);
                var temp = root.left;
                root.left = root.right;
                root.right =temp;
            }
            return root;
        }
    }
}