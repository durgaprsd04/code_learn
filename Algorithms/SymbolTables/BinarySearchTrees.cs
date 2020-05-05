using System;
using System.Collections;
namespace SymbolTables
{
    public class BSTNode<T1,T2> where T1:System.IComparable<T1>
    {
        internal T1 key;
        internal T2 value;
        internal BSTNode<T1,T2> right;
        internal BSTNode<T1,T2> left;
        internal int count;
        public BSTNode(T1 key, T2 value)
        {
            this.key=key;
            this.value=value;
            this.count=1;
        }
        public T1 GetKey(){
            return key;
        }
        public T2 GetValue(){
            return value;
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
            {
                parent= newNode;
                //parent.count +=1;
            }
        }
        public BSTNode<T1,T2> Min()
        {
            if(parent.left==null)
                return parent;
            else
                return Min(parent.left);
        }
        private BSTNode<T1,T2> Min(BSTNode<T1,T2> node)
        {
            if (node.left==null)
                return node;
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
        public BSTNode<T1, T2> Floor(T1 key)
        {
           return Floor(parent, key);
            
        }
        public BSTNode<T1, T2> Ceil(T1 key)
        {
            return Ceil(parent, key);
        }
        public void DeleteMin()
        {
           parent =  DeleteMin(parent);
        }

        public void DeleteNode(T1 node)
        {
            //var root = Floor(node);
            //Console.WriteLine(root.key);
            parent = DeleteNode(parent, node);
        }
        private BSTNode<T1, T2> DeleteNode(BSTNode<T1, T2> root, T1 key)
        {
            if(root ==null)
                return null;
            //Console.WriteLine(root.key);
            
            if(root.key.CompareTo(key)<0 )
            {
                root.right=  DeleteNode(root.right, key);
            }
            else if(root.key.CompareTo(key)> 0)
            {
                root.left = DeleteNode(root.left, key );
            }
            else
            {
                Console.WriteLine(root.key);
                Console.ReadKey();
                if(root.left == null)
                    return root.right;
                if(root.right ==null)
                    return root.left;
                if(root.right!=null && root.left!=null)
                {
                    var v = root;
                    root = Min(v.right);
                    root.right = DeleteMin(v.right);
                    root.left = v.left;
                    return root;                    
                }
            }
            return root;
            
        }
        private BSTNode<T1, T2> DeleteMin(BSTNode<T1, T2> root)
        {
            if(root==null)
                return null;
            if(root.left!=null)
            {
                Console.WriteLine("At root {0}",root.key);
                root.left= DeleteMin(root.left);
                root.count = 1+ Size(root.left) + Size(root.right);
                return root;
            }
            else
                return root.right;

        }
        private BSTNode<T1, T2> Ceil(BSTNode<T1, T2> root, T1 key)
        {
            if(root==null) return null;
            if(root.key.CompareTo(key)< 0)
                return Ceil(root.right, key);
            else if(root.key.CompareTo(key)>0)
            {
                var returnKey = Ceil(root.left, key);
                if(returnKey==null)
                    return root;
                else 
                    return returnKey;
            }
                
            else 
                return root;

        }
        private BSTNode<T1, T2> Floor(BSTNode<T1, T2> root, T1 key)
        {
            if(root==null)
                return null;
            //Console.WriteLine("root.key {0} , key {1}", root.key, key);
            if(root.key.CompareTo(key)<0)
            {
                //root is lesser so there could be on in right node.
                var returnNode = Floor(root.right, key);
                if(returnNode==null)
                    return root;
                else
                    return returnNode;
            }
            else if(root.key.CompareTo(key)>0)
            { 
                return  Floor(root.left, key);
            }
            else
                return root;
        }


        public int Size()
        {
            return Size(parent);
        }
        public int Size(BSTNode<T1, T2> root)
        {
            if(root==null)
                return 0;   
            else
                return root.count;
        }
        public Queue InOrder()
        {
            Queue queue = new Queue();
              InOrder(parent,queue );
              return queue;
        }
        private void InOrder(BSTNode<T1, T2> root, Queue queue)
        {
            if(root==null)
                return;
            InOrder(root.left, queue);
            queue.Enqueue(root.key);
            InOrder(root.right, queue);
            
        }
        // number of keys lesser than the given one.
        public int Rank(T1 key)
        {
            if(parent==null)
                return 0;
            var floor = Floor(key);
            return Rank(parent, floor.key);
        }
        private int Rank(BSTNode<T1, T2> root, T1 key)
        {
            if(root==null)
                return 0;
            //Console.WriteLine("The key one {0}, {1}",key, root.key);
            //Console.ReadKey();
           if(root.key.CompareTo(key)<0)
           { 
               return 1 + Size(root.left) + Rank(root.right, key);
           }
            else if(root.key.CompareTo(key)>0)
            {
                return Rank(root.left, key);
            }
            else
            {
                return Size(root.left);
            }
        }
        private void Add( ref BSTNode<T1, T2> root  ,  BSTNode<T1, T2> child)
        {
            //Console.WriteLine("here 1" +parent.ToString());
            //Console.WriteLine( "here 2"+child.ToString());
            if(root.key.CompareTo(child.key)<0)
            {
                if(root.right==null)
                {
                    root.right=child;
                }
                    
                else
                {
                    Add(ref root.right, child);
                    //root.count+=1;
                }
                    
            }
            else if(root.key.CompareTo(child.key)>0)
            {
                if(root.left==null)
                {
                    root.left=child;
                }
                else
                {
                    Add(ref root.left, child);
                }
                    
            }
            else
            {
                root.value=child.value;
            }
            root.count= 1+ Size(root.left)+Size(root.right);
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
            Console.WriteLine(c+"({0},{1})({2})",root.key, root.value, root.count);
            if(root.right!=null)
                PrintNode(root.right, ' ', n+5);
            if(root.left!=null)
                PrintNode(root.left, ' ', n-5);
            
        }

    }
}