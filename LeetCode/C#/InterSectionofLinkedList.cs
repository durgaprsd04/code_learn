using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
namespace LeetCode
{
    class LinkedListIntersection
    {
      public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        HashSet<ListNode> hashSetA = new HashSet<ListNode>();
        HashSet<ListNode> hashSetB = new HashSet<ListNode>();
        var a= headA;
        var b = headB;
        ListNode res =null;
        while(a!=null ||  b!=null)
        {
          Console.WriteLine($"a {a?.val} b {b?.val} ");
          if(a!=null)
          {
            if(!hashSetB.Contains(a))
              hashSetA.Add(a);
            else
            {
              res =a;
              break;
            }
          }
          if(b!=null)
          {
            if(!hashSetA.Contains(b))
              hashSetB.Add(b);
            else
            {
              res =b;
              break;
            }
          }
          a = a?.next;
          b = b?.next;
        }
        return res;
    }
    }
}

