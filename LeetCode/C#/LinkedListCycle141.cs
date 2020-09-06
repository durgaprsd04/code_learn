using System;
using System.IO;
using System.Linq;
namespace LeetCode
{
    class LinkedListCycle
    {
      public bool HasCycle(ListNode head) {
        var first = head;
        var second = head;
        var flag=false;
        while(second != null || first !=null)
        {
          Console.WriteLine($"second{second.val} first {first.val} ");
          if(second ==first)
          {
            flag=true;
            break;
          }
          first = first.next;
          second = second?.next?.next;
        }
        return flag;
      }
    }
}
