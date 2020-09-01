using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class DeleteDuplicatesClass
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
          if(head==null)
            return null;
           head =  new ListNode(head.val,DeleteNodeRecurse(head.next,head.val));
           return head;
        }
        public ListNode DeleteNodeRecurse(ListNode head, int n)
        {
          if(head==null)
            return null;
          Console.WriteLine($"head {head.val} n {n}");
          if(head.val==n)
            return DeleteNodeRecurse(head.next,n);
          else
            return new ListNode(head.val, DeleteNodeRecurse(head.next,head.val));
        }
    }
}
