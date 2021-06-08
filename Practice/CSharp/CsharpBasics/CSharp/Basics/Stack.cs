using System;
namespace CSharp.Basics
{
   
    public class Stack<T1>
    {
        private Node<T1> node;
        public void Push(T1 val)
        {
            node  = new Node<T1>(val, node);
        }
        public T1 Pop()
        {
            var val = node.val;
            node = node.next;
            return val;
        }
    }
}