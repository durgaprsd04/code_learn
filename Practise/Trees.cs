using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
namespace Practise
{   
    public class Trees<T>  where T:class
    {
        TreeNode<T> root;
        public Trees(T element, TreeNode<T> [] children =null)
        {
            root = new TreeNode<T>(element, children);
        }
        public void Add(T e)
        {
            if(root==null)
                root= new TreeNode<T>(e);
            else if(root.children==null)
                root.children = new [] { new TreeNode<T>(e)};
            else
            {
                Add(root, e);
            }
        }
        public void Add(TreeNode<T> t, T e)
        {
           if(t==null)
                t= new TreeNode<T>(e);
            else if(t.children==null)
                t.children = new [] { new TreeNode<T>(e)};
            else
            {
                if(t.children.Length<2)
                {
                    Console.WriteLine($"Adding {t.children.First()} along with {e} as child of {t}");
                    t.children = new [] {new TreeNode<T>(e), t.children.First()};
                }
                else
                    Add(t.children[0], e);
            }
        }
        public void BFS()
        {

        }
        public void DFS()
        {
            DFS(this.root);
        }
        public void DFS(TreeNode<T> t)
        {
            if(t==null)
                return;
            Console.Write(t);
            if(t.children==null)
                return;
            foreach(var e in t.children)
                DFS(e);
        }
      
    }
    public class TreeNode<T>
    {
        T root;
        public TreeNode<T> [] children;
        public TreeNode(T element, TreeNode<T> [] children =null)
        {
            this.root=element;
            this.children =children;
            
        }
        public override string  ToString()
        {
            return root.ToString();
        }

    }
}