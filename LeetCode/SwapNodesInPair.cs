using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class SwapNodesInPair
    {
        public ListNode SwapPairs(ListNode head) {
          var h = SwapNode(head, true);
          return h;
        }
        ListNode SwapNode(ListNode h, bool swapFlag)
        {
          if(h==null)
              return (null);
          //Console.WriteLine($" val {h.val}");
           ListNode temp =null;
          if(swapFlag)
          {
            var h2 = h;
            if(h.next!=null)
            {
              temp = h.next;
              h.next = h.next.next;
              h =temp;
              h.next = h2;
            }
            if(h.next!=null)
                Console.WriteLine($"h.next.val {h.next.val} h.val {h.val} ");
          }
          h.next =  SwapNode(h.next, !swapFlag);
          return h;
        }
    }
}
