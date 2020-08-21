using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class RemoveNthNode
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n) {
          var v1= lengthFromEnd(head, n);
          head = v1.node ;
          return head;
      }
        public (ListNode node, int len) lengthFromEnd(ListNode h, int n)
        {
          if(h==null)
              return (null,0);
          var v1 =lengthFromEnd(h.next, n);
          h.next = v1.node;
          var lengthFromEnd1 = 1 + v1.len;
          Console.WriteLine($" l {lengthFromEnd1} n {n}");
          if(lengthFromEnd1 == n)
          {
              //Console.WriteLine($"h.val inside {h.next.val}");
              return (h.next, lengthFromEnd1);
          }
          //Console.WriteLine($"h.val {h.val}");
          return (h,lengthFromEnd1);
        }
    }
    /*
     public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
      */
}


