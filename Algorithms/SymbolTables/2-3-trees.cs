using System;
using System.Collections;
namespace SymbolTables
{
    public class twoNode<T1,T2> where T1:System.IComparable<T1>
    {
        internal T1 key;
        internal T2 value ;
        public twoNode(T1 key, T2 value)
        {
            this.key=key;
            this.value=value;
        }

    }
    public class BSTtwo3Node<T1,T2> where T1:System.IComparable<T1>
    {

       internal twoNode<T1,T2> max, min;
        internal BSTtwo3Node<T1,T2> right;
        internal BSTtwo3Node<T1,T2> left;
        internal BSTtwo3Node<T1,T2> center;
        internal int count;
        public BSTtwo3Node(twoNode<T1,T2> value)
        {
            this.min = value;
            this.count=1;
        }
        public T1 GetKey(){
            return min.key;
        }
        public T2 GetValue(){
            return min.value;
        }
    }
    public class two3Tree<T1, T2> where T1:System.IComparable<T1>
    {
        private  BSTtwo3Node<T1,T2> parent;
        public void Add(T1 key, T2 value)
        {
            var valueNode =new twoNode<T1, T2> (key, value);
            //Console.WriteLine("the char is {0}", key);
            parent = Add(ref parent, valueNode);
        }
        private BSTtwo3Node<T1, T2>  Add(ref BSTtwo3Node<T1, T2> root, twoNode<T1,T2> valueNode)
        {
            if(root==null)
            {
                Console.WriteLine("here 1 "+valueNode.key);
                root = new BSTtwo3Node<T1, T2>(valueNode);
                return root;
            }
            else
            {
                if(root.max ==null && root.left ==null && root.right==null && root.center==null)
                {
                    Console.WriteLine("here 2 "+valueNode.key);
                    root.max =  valueNode;
                    Swap(ref root.max, ref root.min);
                }       
                else
                {
                    Console.WriteLine("here 3 "+valueNode.key);
                    if(root.max==null)
                    {
                        if(valueNode.key.CompareTo(root.min.key)<0)
                        {
                            root.left = Add(ref root.left, valueNode);
                           

                        }
                        else if(valueNode.key.CompareTo(root.min.key)>0)
                        {
                            root.right = Add(ref root.right, valueNode);
                             if(root.right.left!=null && root.right.right!=null)
                            {
                                root.center = root.right.left;
                                root.max = root.right.min;
                                root.right = root.right.right;
                                
                                
                            }
                        } 
                    }
                    else
                    {
                         if(valueNode.key.CompareTo(root.min.key)<0)
                        {
                            
                            root.left = Add(ref root.left, valueNode);
                            root.right = new BSTtwo3Node<T1,T2>(root.max);
                            root.max=null;
                        }
                        else if(valueNode.key.CompareTo(root.min.key)>0 && valueNode.key.CompareTo(root.max.key)<0 )
                        {
                            root.center = Add(ref root.center, valueNode);
                        }
                        
                        else if(valueNode.key.CompareTo(root.max.key)>0 )
                        {
                            root.right = Add(ref root.right, valueNode);
                            root.left = new BSTtwo3Node<T1,T2>(root.min);
                            root.min = root.max;
                            root.max=null;
                        }
                    }
                   
                        
                }
            }
            return root;
                  
                  //Console.WriteLine("the tree is {0}", valueNode.key);
        }
        private void Swap(ref twoNode<T1, T2> node1 , ref twoNode<T1,T2> node2)
        {
            if(node1.key.CompareTo(node2.key)<0)
            {
                var temp = node1;
                node1 = node2;
                node2= temp;
            }
            
        }
        public void Print()
        {
            if(parent!=null)
                PrintNode(parent, ' ', 50);
            
        }
        private void PrintNode(BSTtwo3Node<T1,T2> root, char symbol, int n)
        {
            Console.ReadKey();
            if(n<0)
                n=0;
            var c = new string(symbol, n);
            //Console.WriteLine("here");
            Console.Write(c+"({0},{1})({2})",root.min.key, root.min.value, root.count);
            if(root.max!=null)
            {
                Console.Write(" ({0},{1})({2})",root.max.key, root.max.value, root.count);
            }
            Console.WriteLine();
            if(root.right!=null)
                PrintNode(root.right, ' ', n+10);
            if(root.center!=null)
                PrintNode(root.center, ' ', n);
            if(root.left!=null)
                PrintNode(root.left, ' ', n-7);
            
        }
    }
}
