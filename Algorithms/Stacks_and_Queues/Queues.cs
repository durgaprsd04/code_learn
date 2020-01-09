using System;
namespace Stacks_and_Queues
{
    public class Queues
    {
        public Node first, last;
        public class Node
        {
            public string item;
            public  Node node;
        }   
        public bool isEmpty()
        {
            return first==null;
        }     
        public void Enqueue(string var)
        {
            Node oldlast = last;
            last = new Node();
            last.item=var;
            last.node= null; 
            if(isEmpty())
            first =last;
            else
            oldlast.node = last; 
        }
        public string Dequeue()
        {
            string var1 = first.item;
            first = first.node;
            if(isEmpty())last =null;
            return var1;
        }
    }
}
