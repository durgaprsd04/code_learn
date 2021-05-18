using System.Collections.Generic;

namespace LeetCode2.LinkedList
{
    public class DoubleListNode
    {
        public int val;
        public DoubleListNode next;
        public DoubleListNode prev;
        public DoubleListNode(int val, DoubleListNode next, DoubleListNode prev)
        {
            this.val = val;
            this.next = next;
            this.prev = prev;
        }
    }
}