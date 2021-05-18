using System;
using System.Collections.Generic;
namespace LeetCode2.LinkedList
{
    public class DoubleListNodeOpertions
    {
        public DoubleListNode Init(int n)
        {
            DoubleListNode node = null;
            for(int i=1;i<=n;i++)
            {
                var prev = node;
                node = new DoubleListNode(i, node, null);
                if(prev!=null)
                    prev.prev = node;
            }
            return node;
        }
        public void Print(DoubleListNode d )
        {
            var backup = d;
            DoubleListNode lastNode=null;
            Console.WriteLine();
            Console.WriteLine("Forward");
            while(backup!=null)
            {
                Console.Write(backup.val +"->");
                if(backup.next==null)
                    lastNode = backup;
                backup = backup.next;
            }
            Console.WriteLine("\nBackward");
            while(lastNode!=null)
            {
                Console.Write(lastNode.val +"->");
                if(lastNode.prev==null)
                    backup = lastNode;
                lastNode = lastNode.prev;
            }
             Console.WriteLine();
            Console.WriteLine("Forward");
            while(backup!=null)
            {
                Console.Write(backup.val +"->");
                if(backup.next==null)
                    lastNode = backup;
                backup = backup.next;
            }
        }
        public DoubleListNode InsertInPosition(DoubleListNode d , int position, int val)
        {
            int i=0;
            for(var node=d;node!=null;node=node.next, i++)
            {
                if(i==position)
                    {
                        var backup = node.next;
                        node.next = new DoubleListNode(val, null,null);
                        node.next.next =backup;
                        node.next.prev = node;
                        backup.prev = node.next;
                    }
            }
            return d;
        }
        public DoubleListNode Reverse(DoubleListNode d )
        {
            for(var node=d;node!=null;node=node.prev)
            {
                var swap = node.prev;
                node.prev = node.next;
                node.next = swap;
            }
            return d;
        }
    }
}