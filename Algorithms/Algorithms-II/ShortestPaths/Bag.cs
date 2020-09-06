using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
namespace ShortestPaths
{

    public class Node<T> where T:System.IComparable<T>
    {
        public T element;
        public Node<T> next;
        public Node( T element)
        {
            this.element=element;
        }
        public override string ToString()
        {
            return element.ToString();
        }
    }
    public class Bag<T> where T:class, System.IComparable<T>
    {
        private Node<T> node ;
        public Bag(T element)
        {
            node = new Node<T>(element);
        }
        public void Add(T element)
        {
            node.next =Add(node.next , element);
        }
        public void Delete(T element)
        {
            if(node.element.CompareTo(element)==0)
            {
                node.element = default(T);
            }
            else
            {
                DeleteNode(node.next ,  element);
            }
        }
        public IList<T> GetIterator()
        {
           Queue q = new Queue();
           var iterator = node;
           while(iterator!=null)
           {
                q.Enqueue(iterator.element);
                iterator= iterator.next;
           }
           return  q.ToArray().Select(x=>  x as T).ToList();
        }
        public override string ToString()
        {
            return  GetNodeList(node);
        }
        private string  GetNodeList(Node<T> n)
        {
            var newNode = n;
            var str ="";
            while(newNode!=null)
            {
               str = str+ "->"+newNode.ToString();
               newNode = newNode.next;
            }
            return str;
        }
        private void DeleteNode( Node<T> n, T element)
        {
            if(n.element.CompareTo(element)==0)
            {
                n=null;
            }
            else
            {
                if(n!=null)
                    DeleteNode(n.next, element);
            }
        }
        private Node<T> Add(Node<T> n, T element)
        {
             //Console.WriteLine("ading added {0} ",element);
            if(n==null)
            {
                //Console.WriteLine("the one coming {0}",element);
                n= new Node<T>(element);
            }
            else
            {
                n.next = Add(n.next , element);
            }
            return n;
        }

    }
}
