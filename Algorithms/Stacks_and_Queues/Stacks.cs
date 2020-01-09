using System;
namespace Stacks_and_Queues
{
    public class LinkedListStackofStrings
    {
        private Node first;
        private class Node
        {
            public string Name;
            public Node next;
        }
    
    public string Pop()
        {
            string item = first.Name;
            first = first.next;
            return item;
        }
    public void Push(string name)
        {
            Node oldfirst = first;
            first = new Node();
            first.Name=name;
            first.next=oldfirst;
        }
    public bool IsEmpty()
        {
            return first ==null;
        }
    public string Current()
    {
        return first.Name;
    }
    }
}