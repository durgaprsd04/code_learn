using System;
namespace CSharp.Basics
{
   
 public class Node<T>
    {
        public T val;
        public Node<T> next;
        public Node(T val, Node<T> next)
        {
            this.val =val;
            this.next = next;
        }
    }
}