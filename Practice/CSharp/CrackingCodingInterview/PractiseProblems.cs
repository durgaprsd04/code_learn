using System;
using System.Collections.Generic;
namespace CrackingCodingInterview
{
    class PractiseProblems
    {
        public ListNode FindNth(ListNode node, int n)
        {
            var p1 = node;
            var p2 = node;
            int i=0;
            while(i<n)
            {
                if (p2.next!=null)
                {
                    p2 = p2.next;
                }
            }
            while(p2.next !=null)
            {
                p1=p1.next;
                p2= p2.next;
            }
            return p1;
        }
        public List<List<TreeNode>> BFS(TreeNode node)
        {
            var v = node;
            List<List<TreeNode>> final = new List<List<TreeNode>>();
            List<TreeNode> l =new List<TreeNode>();
            if(node.left!=null)
                l.Add(node.left);
            if(node.right!=null)
                l.Add(node.left);
         
            while(l.Count>0)
            {
                final.Add(l);
                l = BFS1(l);
            }
            return final;
        } 
        public List<TreeNode> BFS1(List<TreeNode> list)
        {
            var l2 = new List<TreeNode>();
            foreach(var node in list)
            {
                if(node.left!=null)
                    l2.Add(node.left);
                if(node.right!=null)
                    l2.Add(node.right);
            }
            return l2;
        }
    }
}