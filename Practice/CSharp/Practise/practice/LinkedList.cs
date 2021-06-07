using System;
namespace Practise
{
   public class LinkedList<T> where T:class
    {
       private Node<T> node1;
        public void Add(T element)
        {
            if(this.node1==null)
             this.node1 = new Node<T>(element);
            else
            {              
                this.node1 = new Node<T>(element, this.node1);
            }              
        }
        public void Traverse()
        {
            Traverse(this.node1);
        }
        private void Traverse(Node<T> nod1)
        {
            if(nod1!=null)
            {
                Console.Write(nod1.ToString());
                Traverse(nod1.Next);
            }
        }
        public Node<T> GetLast()
        {
            return GetLast(this.node1);
        }
        private Node<T> GetLast(Node<T> nod1)
        {
            if(nod1.Next==null)
                return nod1;
            else 
                return GetLast(nod1.Next);
        }
    }
    public class Node<T> where T:class
    {
        private T element;
        private Node<T> next;
        public Node(T element, Node<T> node=null)
        {
            this.element= element;
            this.Next = node;
        }

        public Node<T> Next { get => next; set => next = value; }

        public override string ToString()
        {
            return element.ToString();
        }
    }

}
