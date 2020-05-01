using System;
namespace SymbolTables
{
    public class BSTNode<T1,T2> where T1:System.IComparable<T1>
    {
        internal T1 key;
        internal T2 value;
        internal BSTNode<T1,T2> right;
        internal BSTNode<T1,T2> left;
        public BSTNode(T1 key, T2 value)
        {
            this.key=key;
            this.value=value;
        }
    }
    public class BST<T1, T2>  where T1 : System.IComparable<T1>
    {
        private BSTNode<T1, T2> parent;
       public void Add(T1 key, T2 value)
        {
            
            var newNode = new BSTNode<T1,T2>(key,value);
            if(parent!=null)
                Add(ref parent,   newNode);
            if(parent==null)
                parent= newNode;
            
        }
        public T1 Min()
        {
            if(parent.left==null)
                return parent.key;
            else
                return Min(parent.left);
        }
        private T1 Min(BSTNode<T1,T2> node)
        {
            if (node.left==null)
                return node.key;
            else
                return Min(node.left);
        }
        public T1 Max()
        {
            if(parent.right==null)
                return parent.key;
            else
                return Max(parent.right);
        }
        private T1 Max(BSTNode<T1,T2> node)
        {
            if (node.right==null)
                return node.key;
            else
                return Max(node.right);
        }
        public T1 Floor(T1 key)
        {
            if(parent==null)
                return default(T1);
            if(parent.key.CompareTo(key)<0)
            {
                //left is lesser so there could be on in right node.
                var returnNode = Floor(parent.right, key);
                if(returnNode.Equals(default(T1)))
                    return parent.key;
                else
                    return returnNode;
            }
            else if(parent.key.CompareTo(key)>0)
            {
                var returnNode = Floor(parent.left, key);
                if(returnNode.Equals(default(T1)))
                    return parent.key;
                else
                    return returnNode;
            }
            else
                return parent.key;
            
        }
        private T1 Floor(BSTNode<T1, T2> root, T1 key)
        {
            if(root==null)
                return default(T1);
            if(root.key.CompareTo(key)<0)
            {
                //root is lesser so there could be on in right node.
                var returnNode = Floor(root.right, key);
                if(returnNode.Equals(default(T1)))
                    return root.key;
                else
                    return returnNode;
            }
            else if(root.key.CompareTo(key)>0)
            {
                var returnNode = Floor(root.left, key);
                if(returnNode.Equals(default(T1)))
                    return root.key;
                else
                    return returnNode;
            }
            else
                return root.key;
        }


        public int Size()
        {
            int size=0;
            if(parent==null)
                return 0;
            size += Size(parent.left);
            size +=Size(parent.right);
        }
        private  int Size

        // number of keys lesser than the given one.
        public int Rank(T1 key)
        {
            if(parent==null)
                return 0;
            if(parent.key.CompareTo(key)<0)
            {
                //this is lesser
                return 1 + Rank(parent.left, key);
            }
        }
        private int Rank(BSTNode<T1, T2> root, T1 key)
        {
            int rank=0;
            if(root==null)
                return 0;
            if(root.key.CompareTo(key)<0)
                rank+=Rank(root.left, key);
            rank+=Rank(root.right, key);
            return rank;    
            
        }
        private void Add( ref BSTNode<T1, T2> root  ,  BSTNode<T1, T2> child)
        {
            //Console.WriteLine("here 1" +parent.ToString());
            //Console.WriteLine( "here 2"+child.ToString());
            if(root.key.CompareTo(child.key)<0)
            {
                if(root.right==null)
                    root.right=child;
                else
                    Add(ref root.right, child);
            }
            else if(root.key.CompareTo(child.key)>0)
            {
                if(root.left==null)
                    root.left=child;
                else
                    Add(ref root.left, child);
            }
            else
            {
                root.value=child.value;
            }
        }
        public void Print()
        {
            if(parent!=null)
                PrintNode(parent, ' ', 25);
            
        }
        private void PrintNode(BSTNode<T1,T2> root, char symbol, int n)
        {
            if(n<0)
                n=0;
            var c = new string(symbol, n);
            Console.WriteLine(c+"({0},{1})",root.key, root.value);
            if(root.right!=null)
                PrintNode(root.right, ' ', n+5);
            if(root.left!=null)
                PrintNode(root.left, ' ', n-5);
            
        }

    }
}