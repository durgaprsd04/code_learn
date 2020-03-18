using System;
using System.Collections.Generic;
namespace SymbolTables
{
    public class Nodenew
    {
        public char key;
        public int value;
         public Nodenew(char key, int value)
        {
            this.key=key;
            this.value=value;

        }
        public Nodenew Next;
        public override string ToString()
        {
            return string.Format("[{0}:{1}]",this.key,this.value);
        }
    }
    public class ST
    {
        private Nodenew head;
        public void Add(char key, int value)
        {
            
            var newNode = new Nodenew(key,value);
            if(head!=null)
                Add( ref head,  newNode );
            if(head==null)
                head= newNode;
            
        }
        private void Add( ref Nodenew  parent,  Nodenew child)
        {
            Console.WriteLine("here 1" +parent.ToString());
            Console.WriteLine( "here 2"+child.ToString());
            if(parent.key==child.key)
            {
                parent.value=child.value;
                return;

            }
            if(parent.Next!=null)
            {
                Add(ref parent.Next,child);
            }
            if(parent.Next==null)
            {
                parent.Next=child;
                return;
            }
        }
        public int Search(char key)
        {
            if(head.key==key)
                return head.value;
            else
                return Search(head.Next,key);
        }
        private int Search(Nodenew nodenew, char key)
        {
            if(nodenew==null)
                return -1;
            if(nodenew.key==key)
                return nodenew.value;
            else{
                return Search(nodenew.Next,key);
            }
        }
        public bool Remove (char c )
        {
            if(head.key==c)
            {       
                head = head.Next;
                return true;
            }
            else
                return Remove(ref head.Next,c);
        }
        private bool Remove(ref Nodenew node , char c)
        {
            if(node==null)
                return false;
            if(node.key==c)
            {
                node= node.Next;
                return true;
            }
            else 
                return Remove(ref node.Next, c);   
        }
        public int Size()
        {
            if(head!=null)
                return 1+Size(head.Next);
            else
                return 0;
        }
        public List<char> Keys()
        {
            var v=  new List<char>(){this.head.key};
            v.AddRange(Keys(head.Next));
            return v;
        }
        private List<char> Keys(Nodenew parent)
        {
            if(parent==null)
                return new List<char>();
             var v=  new List<char>(){parent.key};
             v.AddRange(Keys(parent.Next));
             return v;
        }
        private int Size(Nodenew parent)
        {
            if(parent==null)
                return 0;
            if(parent.Next!=null)
                return (1+Size(parent.Next));
            return 1;
        }
        public void Print()
        {

            Print(head);
           
        }
        private void Print(Nodenew node)
        {
            if(node==null)
                return;
            Console.Write("[{0}{1}]>",node.key,node.value);
            if(node.Next!=null)
                Print(node.Next);
        }
    }
}
