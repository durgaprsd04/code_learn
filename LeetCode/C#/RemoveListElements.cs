using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class RemoveListElementsClass
    {
      public ListNode RemoveElements(ListNode head, int val) {
        return  RemoveElement(head, val);
    }
      public ListNode RemoveElement(ListNode head, int val)
      {
         if(head ==null)
           return null;
          if(head.next == null)
            if(head.val!=val)
              return head;
            else
              return null;
          if(head.val == val)
            return  RemoveElement(head.next, val);
          else
            return new ListNode( head.val,  RemoveElement(head.next, val));
      }
    }
}

