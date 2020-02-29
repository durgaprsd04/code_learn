using System;
namespace SymbolTables
{
    public class Node
    {
        public string value;
        public Node left;
        public Node right;
    }
    public class BinarySearchTree
    { 
        private Node root;
        public void Add(string key)
        {
           AddItem(ref root, key);
                
        }
        private void AddItem(ref Node root,string key)
        {
             if(root==null)
            {
                //Console.WriteLine("here in adding item"+key);
                root = new Node();
                root.value=key;
            }
            else
            {
                if(string.Compare(root.value,key)>0)
                {
                    //Console.WriteLine("Adding {0} to left of {1}",key,root.value);
                    AddItem(ref root.left,key);
                    
                }
                else
                {
                    //Console.WriteLine("Adding {0} to right {1}",key, root.value);
                    AddItem(ref root.right, key);
                    
                }
            }
        }
        public bool Search(string key)
        {
            return Search(root, key);

            
        }
        private bool Search(Node node, string key)
        {
            if(node==null)
                return false;
            if(node.value==key)
                return true;
            
            bool i=false;
            if(node.left!=null)
                i= Search(node.left,key);
            if(node.right!=null)
                i = i||  Search(node.right,key);
            return i;
        }
        public  string Max()
        {
            return Max(root);
        }
        private string Max(Node node)
        {
            string max = string.Empty,leftmax=string.Empty,rightmax=string.Empty;
            if(node==null)
                return string.Empty;
            max=node.value;
            if(node.left!=null)
            {
                leftmax=Max(node.left);
                //Console.WriteLine(leftmax);
                max = (string.Compare(node.value, leftmax)>0)?node.value:leftmax;
            }   
            if(node.right!=null)
            {
                rightmax=Max(node.right);
                //Console.WriteLine(rightmax);
                max = (string.Compare(leftmax, rightmax)>0)?leftmax:rightmax;
            }
            //Console.WriteLine(max);
            return max;
        }
        public string Min()
        {
            return Min(root);
        }
        public string Min(Node node)
        {
            string min = string.Empty,leftmin=string.Empty,rightmin=string.Empty;
            if(node==null)
                return null;
            min=node.value;
            if(node.left!=null)
            {
                leftmin=Min(node.left);
                //Console.WriteLine(leftmin);
                min = (leftmin!=null)?node.value:leftmin;
            }   
            if(node.right!=null)
            {
                rightmin=Min(node.right);
                //Console.WriteLine(rightmin);
                min = (string.Compare(leftmin, rightmin)>0)?leftmin:rightmin;
            }
            Console.WriteLine(min);
            return min;
        }
        public string Ceil(string key)
        {
            return string.Empty;
        }
        public string Floor(string key)
        {
            return string.Empty;
        }
        public int Rank(string key)
        {
            return 0;
        }
        public int Size(string key)
        {
            return Size(root, key,false);
        }
        private int Size(Node root, string key, bool isFound)
        {
            int size=0;
            if(root==null)
            {
                return 0;
            }
            //Console.Write(root.value);
            if(root.value==key || isFound)
            {   
                //Console.WriteLine("insert "+root.value+"key "+key);
                if(root.left!=null)
                    size+=(1+Size(root.left,key, true));   
                if(root.right!=null)
                    size+=(1+Size(root.right,key, true));  
                return size; 
            }
            else
            {
            if(root.left!=null)
                size+=Size(root.left,key, false);
            if(root.right!=null)
                size+=Size(root.right,key, false);
            return size;
            }
            
            //Console.WriteLine("not so impossible"+root.value+":"+key);
            //return 0;
        }
        public void Print()
        {
            //Console.WriteLine("Size of h"+Size("q"));
            //Console.WriteLine("The element x exists in "+ Search("y"));
            Console.WriteLine("The max element is {0}", Max());
            Print(root, '?');
        }
        private void Print(Node n , char j)
        {
            if(n==null)
            {       
                //Console.WriteLine("Weird line");
                return;
            }
            //Console.WriteLine( Size(n.value));
            Console.Write(new String(j,1+Size(n.value))+n.value);
            Console.WriteLine();
            if(n.left!=null)
                Print(n.left, '>');
            if(n.right!=null)
                Print(n.right, '<');
            

        }
    }
}