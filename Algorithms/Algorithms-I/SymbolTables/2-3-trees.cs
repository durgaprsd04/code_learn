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
                Console.WriteLine("root is null case "+valueNode.key);
                root = new BSTtwo3Node<T1, T2>(valueNode);
                return root;
            }
            else
            {
                if(root.max ==null && root.left ==null && root.right==null && root.center==null)
                {
                    Console.WriteLine("max is null case "+valueNode.key);
                    root.max =  valueNode;
                    Swap(ref root.max, ref root.min);
                }       
                else
                {
                    
                    if(root.max==null)
                    {
                        Console.WriteLine("node is not full case "+valueNode.key);
                        if(valueNode.key.CompareTo(root.min.key)<0)
                        {
                            root.left = Add(ref root.left, valueNode);
                            if(root.left.left!=null && root.left.right!=null)
                            {
                                root.center = root.left.right;
                                root.max = root.left.min;
                                root.left = root.left.left;
                            }

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
                        string c;
                        if(root.min.key==null)
                         c = "null";
                        else
                            c=root.min.key.ToString();

                        Console.WriteLine("node is  full case {0} on {1}",valueNode.key,c );
                         if(valueNode.key.CompareTo(root.min.key)<0)
                        {
                            
                            root.left = Add(ref root.left, valueNode);
                            if(root.right==null)
                            {
                                root.right = new BSTtwo3Node<T1,T2>(root.max);
                                root.max=null;
                            }
                            
                        }
                        else if(valueNode.key.CompareTo(root.min.key)>0 && valueNode.key.CompareTo(root.max.key)<0 )
                        {
                            root.center = Add(ref root.center, valueNode);
                        }
                        
                        else if(valueNode.key.CompareTo(root.max.key)>0 )
                        {
                            bool rightWasNull=false, maxWasNull=true, transformHappened=false;

                            if(root.right==null)
                                rightWasNull=true;
                            else
                            {
                                if(root.right.max==null)
                                    maxWasNull = true;
                                else
                                    maxWasNull=false;
                            }
                            root.right = Add(ref root.right, valueNode);
                            if(root.right.max==null && !maxWasNull)
                                transformHappened=true;
                            if(rightWasNull)
                            {
                                //Console.WriteLine("herel"+valueNode.key.ToString());
                                root.left = new BSTtwo3Node<T1,T2>(root.min);
                                root.min = root.max;
                                root.max=null;
                            } 
                           if(transformHappened)
                            {
                                var newleftroot = new BSTtwo3Node<T1,T2>(root.min);
                                newleftroot.left = root.left;
                                newleftroot.right =  root.center;

                                var mainnode =  new BSTtwo3Node<T1,T2>(root.max);
                                mainnode.right = root.right;
                                mainnode.left = newleftroot;
                                root = mainnode;

                            }
                            
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
                PrintNode(parent, ' ', 50, '*');
            
        }
        private void PrintNode(BSTtwo3Node<T1,T2> root, char symbol, int n, char location)
        {
            Console.ReadKey();
            if(n<0)
                n=0;
            var c = new string(symbol, n);
            //Console.WriteLine("here");
            Console.Write(c+"({0},{1})({2}({3}))",root.min.key, root.min.value, root.count, location);
            if(root.max!=null)
            {
                Console.Write(" ({0},{1})({2}({3}))",root.max.key, root.max.value, root.count,location);
            }
            Console.WriteLine();
            if(root.right!=null)
                PrintNode(root.right, ' ', n+10,'r');
            if(root.center!=null)
                PrintNode(root.center, ' ', n,'c');
            if(root.left!=null)
                PrintNode(root.left, ' ', n-7,'l');
            
        }
    }
}
