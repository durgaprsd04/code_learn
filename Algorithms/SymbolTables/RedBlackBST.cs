using System;
namespace SymbolTables
{

    public class RedBlackNode<T1,T2> where T1:System.IComparable<T1>
    {
        internal T1 key;
        internal T2 value;
        internal RedBlackNode<T1, T2> right;
        internal RedBlackNode<T1, T2> left;
        internal bool isRed;
        public RedBlackNode(T1 key, T2 value)
        {
            this.key =key;
            this.value= value;
            this.isRed=false;
        }
        public override string  ToString()
        {
            if(this.isRed)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Black;
            return string.Format("({0}: {1})", key.ToString(), value.ToString());
        }
    }
    public class RedBlackTree<T1, T2> where T1:System.IComparable<T1>
    {
        internal RedBlackNode<T1, T2> redBlackNode ;
        public void Add(T1 key, T2 value)
        {
            var valueNode = new RedBlackNode<T1, T2>(key, value);
            this.redBlackNode = AddNode( this.redBlackNode, valueNode);
        }
       public void Print()
        {
            if(redBlackNode!=null)
                PrintNode(redBlackNode, ' ', 50);
            
        }
        private void PrintNode(RedBlackNode<T1,T2> root, char symbol, int n)
        {
            if(n<0)
                n=0;
            var c = new string(symbol, n);
            if(root.isRed)
                Console.ForegroundColor = ConsoleColor.Red;
            else 
                Console.ForegroundColor=ConsoleColor.Black;
            Console.WriteLine(c+"({0},{1}))",root.key, root.value);
            if(root.right!=null)
                PrintNode(root.right, ' ', n+8);
            if(root.left!=null)
                PrintNode(root.left, ' ', n-8);
            
        }
        private  RedBlackNode<T1, T2>  AddNode(  RedBlackNode<T1, T2> redBlackNode, RedBlackNode<T1, T2> valueNode)
        {
            if (redBlackNode ==null)
            {
                redBlackNode = valueNode;
                redBlackNode.isRed=true;
            } 
            if(redBlackNode.key.CompareTo(valueNode.key)>0)
                redBlackNode.left = AddNode( redBlackNode.left, valueNode);
            else if(redBlackNode.key.CompareTo(valueNode.key)<0)
                redBlackNode.right = AddNode( redBlackNode.right, valueNode);
            else
            {
                redBlackNode.value = valueNode.value;
                return redBlackNode;
            } 
            Console.WriteLine(redBlackNode);
            if(redBlackNode.right!=null)
            {
                //rotate left 
                if(isRed(redBlackNode.right)&& !isRed(redBlackNode.left))
                {
                    //Console.WriteLine(redBlackNode.left);
                   // Console.WriteLine(redBlackNode.right);
                   // Console.WriteLine(redBlackNode);
                  // Console.WriteLine("After {0} is added rotate left called ",valueNode.key.ToString());
                   redBlackNode= RotateLeft( redBlackNode);
                }
               
            }
            if(redBlackNode.left!=null)
            {
                if(redBlackNode.left.left!=null  )
                {
                    if(isRed(redBlackNode.left) && isRed( redBlackNode.left.left))
                    {
                        //Console.WriteLine("After {0} is added rotate right called ",valueNode.key.ToString());
                        redBlackNode = RotateRight(redBlackNode);
                    }
                }
            }
             if(redBlackNode.right!=null)
            {
             if(isRed(redBlackNode.left) && isRed(redBlackNode.right))
                {
                    //Console.WriteLine("flip colors");
                    FlipColors(redBlackNode);
                }
            }
            return redBlackNode;
        }

        private RedBlackNode<T1, T2> RotateRight(RedBlackNode<T1, T2> redBlackNode)
        {
            //Console.WriteLine("rotate right called with "+redBlackNode.key.ToString());
            var v = redBlackNode.left;
            redBlackNode.left = v.right;
            v.right= redBlackNode;
            v.right.isRed=true;
            v.left.isRed=true;
            return v;

        }

        private RedBlackNode<T1, T2>  RotateLeft( RedBlackNode<T1, T2> node)
        {
            if(node.right==null)
                return node;
            var nodeColor= node.isRed;
            //Console.WriteLine("rotate left called with "+node.key.ToString());
            var v = node.right;
            if(node.right!=null)
            //Console.WriteLine("rotate left called with "+node.right.key.ToString());
            node.right= v.left;
            v.left =node;
            v.isRed=nodeColor;
            node.isRed=true;
            return v;
        }

        private void FlipColors(RedBlackNode<T1, T2> redBlackNode)
        {
             //Console.WriteLine("flip colors called with "+ redBlackNode.key.ToString());
            redBlackNode.right.isRed=false;
            redBlackNode.left.isRed=false;
            redBlackNode.isRed=true;
        }

        private bool isRed(RedBlackNode<T1, T2> redBlackNode)
        {
            if(redBlackNode!=null)
             return redBlackNode.isRed;
            else
            return false;
        }
    }
}