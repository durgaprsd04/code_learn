using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class LinkedListReverse
    {
          public ListNode ReverseList(ListNode head)
          {
            head = ReverseList1( head);
            return head;
          }
          private ListNode  ReverseList1(ListNode head)
          {
            if(head==null)
              return null;
            if(head.next ==null)
              return new ListNode(head.val, null);
            else
            {
                var v = ReverseList1(head.next);
                var v1= v;
                var  c= new ListNode(head.val, null);
                while(v1.next!=null)
                  v1 = v1.next;
                v1.next=c;
                return v;
            }
          }
    }
}
